using BusinessLibrary.Models;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ExitInvoiceManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idBusiness"></param>
        /// <param name="products"></param>
        /// <param name="date"></param>
        /// <param name="destiny"></param>
        /// <returns></returns>
        public static bool InsertExitInvoice(string idBusiness, List<ProductModel> products, string date, string destiny)
        {
            try
            {
                string[] exitInvoice = new string[] { idBusiness, date, destiny };
                if (ValidateData.VerifyFields(exitInvoice))
                {
                    ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                    {
                        Date = date,
                        Destiny = destiny,
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExitInvoice"></param>
        /// <param name="idBusiness"></param>
        /// <param name="products"></param>
        /// <param name="date"></param>
        /// <param name="destiny"></param>
        /// <returns></returns>
        public static bool UpdateExitInvoiceById(string idExitInvoice, string idBusiness, List<ProductModel> products, string date, string destiny)
        {
            try
            {
                string[] exitInvoice = new string[] { idExitInvoice, idBusiness, date, destiny };
                if (ValidateData.VerifyFields(exitInvoice))
                {
                    ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                    {
                        IdExitInvoice = int.Parse(idExitInvoice),
                        Date = date,
                        Destiny = destiny,
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExitInvoice"></param>
        /// <returns></returns>
        public static bool DeleteExitInvoiceById(string idExitInvoice)
        {
            try
            {
                string[] exitInvoice = new string[] { idExitInvoice };
                if (ValidateData.VerifyFields(exitInvoice))
                {
                    ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                    {
                        IdExitInvoice = int.Parse(idExitInvoice)
                    };
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExitInvoice"></param>
        /// <returns></returns>
        public static ExitInvoiceModel SelectExitInvoiceById(string idExitInvoice)
        {
            try
            {
                string[] exitInvoice = new string[] { idExitInvoice };
                if (ValidateData.VerifyFields(exitInvoice))
                {
                    ExitInvoiceModel exitInvoiceModel = new ExitInvoiceModel()
                    {
                        IdExitInvoice = int.Parse(idExitInvoice)
                    };
                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ExitInvoiceModel> SelectAllexitInvoices()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
