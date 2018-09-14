using BusinessLibrary.Connection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ExitInvoiceManagement
    {
        public static bool VerifyFields(string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    return false;
                }
            }
            return false;
        }

        public static bool InsertExitInvoice(string idBusiness, string idInputInvoice, List<ProductModel> products, string date, string destiny)
        {
            try
            {
                //TEMP
                string[] exitInvoice = new string[] { idBusiness, idInputInvoice, date, destiny };

                ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                {
                    Date = date,
                    Destiny = destiny,
                    Products = products,
                    IdBusiness = int.Parse(idBusiness)
                };

                if (VerifyFields(exitInvoice))
                {
                    ExitInvoiceConnection.InsertExitInvoice(exitInvoiceModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool UpdateExitInvoiceById(string idBusiness, string idInputInvoice, List<ProductModel> products, string date, string destiny)
        {
            try
            {
                //TEMP
                string[] exitInvoice = new string[] { idBusiness, idInputInvoice, date, destiny };

                ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                {
                    Date = date,
                    Destiny = destiny,
                    Products = products,
                    IdBusiness = int.Parse(idBusiness)
                };

                if (VerifyFields(exitInvoice))
                {
                    ExitInvoiceConnection.UpdateExitInvoice(exitInvoiceModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool DeleteExitInvoiceById(string idInputInvoice)
        {
            try
            {
                //TEMP
                string[] exitInvoice = new string[] { idInputInvoice };
                //TEMP
                ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                {
                    IdInputInovice = int.Parse(idInputInvoice)
                };

                if (VerifyFields(exitInvoice))
                {
                    return ExitInvoiceConnection.DeleteExitInvoice(exitInvoiceModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static ExitInvoiceModel SelectExitInvoiceById(string idInputInvoice)
        {
            try
            {
                //TEMP
                string[] exitInvoice = new string[] { idInputInvoice };
                ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                {
                    IdInputInovice = int.Parse(idInputInvoice)
                };
                if (VerifyFields(exitInvoice))
                {
                    return ExitInvoiceConnection.SelectExitInvoice(exitInvoiceModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }

        public static List<ExitInvoiceModel> SelectAllexitInvoices()
        {
            try
            {
                return ExitInvoiceConnection.SelectAllExitInvoice();
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }
    }
}
