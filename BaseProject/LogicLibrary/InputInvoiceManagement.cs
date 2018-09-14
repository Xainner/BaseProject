using BusinessLibrary.Connection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class InputInvoiceManagement
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

        public static bool InsertinputInvoice(string idInputInvoice, List<ProductModel> products, string date, string provider)
        {
            try
            {
                //TEMP
                string[] inputInvoice = new string[] { idInputInvoice, date, provider };

                InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                {
                    Date = date,
                    Provider = provider,
                    Products = products,
                }; ;

                if (VerifyFields(inputInvoice))
                {
                    InputInvoiceConnection.InsertInputInvoice(inputInvoiceModel);
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

        public static bool UpdateinputInvoiceById(string idInputInvoice, List<ProductModel> products, string date, string provider)
        {
            try
            {
                //TEMP
                string[] inputInvoice = new string[] { idInputInvoice, date, provider };
                //TEMP
                InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                {
                    IdInputInovice = int.Parse(idInputInvoice),
                    Date = date,
                    Provider = provider,
                    Products = products,
                };

                if (VerifyFields(inputInvoice))
                {
                    InputInvoiceConnection.UpdateInputInvoice(inputInvoiceModel);
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

        public static bool DeleteinputInvoiceById(string idInputInvoice)
        {
            try
            {
                //TEMP
                string[] inputInvoice = new string[] { idInputInvoice };
                //TEMP
                InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                {
                    IdInputInovice = int.Parse(idInputInvoice)
                };

                if (VerifyFields(inputInvoice))
                {
                    return InputInvoiceConnection.DeleteInputInvoice(inputInvoiceModel);
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

        public static InputInvoiceModel SelectinputInvoiceById(string idInputInvoice)
        {
            try
            {
                //TEMP
                string[] inputInvoice = new string[] { idInputInvoice };
                InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                {
                    IdInputInovice = int.Parse(idInputInvoice)
                };
                if (VerifyFields(inputInvoice))
                {
                    return InputInvoiceConnection.SelectInputInvoice(inputInvoiceModel);
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

        public static List<InputInvoiceModel> SelectAllinputInvoices()
        {
            try
            {
                return InputInvoiceConnection.SelectAllInputInvoice();
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }
    }
}
