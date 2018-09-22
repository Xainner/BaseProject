using BusinessLibrary.Connection;

using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class InputInvoiceManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="products"></param>
        /// <param name="date"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool InsertinputInvoice(List<ProductModel> products, string date, string provider)
        {
            try
            {
                string[] inputInvoice = new string[] { date, provider };
                if (DataManagement.VerifyFields(inputInvoice))
                {
                    InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                    {
                        Date = date,
                        Provider = provider,
                    }; ;
                    return InputInvoiceConnection.InsertInputInvoice(inputInvoiceModel);
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
        /// <param name="idInputInvoice"></param>
        /// <param name="products"></param>
        /// <param name="date"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool UpdateinputInvoiceById(string idInputInvoice, List<ProductModel> products, string date, string provider)
        {
            try
            {
                string[] inputInvoice = new string[] { idInputInvoice, date, provider };
                if (DataManagement.VerifyFields(inputInvoice))
                {
                    InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                    {
                        IdInputInovice = int.Parse(idInputInvoice),
                        Date = date,
                        Provider = provider,
                    };
                    return InputInvoiceConnection.UpdateInputInvoice(inputInvoiceModel);
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
        /// <param name="idInputInvoice"></param>
        /// <returns></returns>
        public static bool DeleteInputInvoiceById(string idInputInvoice)
        {
            try
            {
                string[] inputInvoice = new string[] { idInputInvoice };
                if (DataManagement.VerifyFields(inputInvoice))
                {
                    InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                    {
                        IdInputInovice = int.Parse(idInputInvoice)
                    };
                    return InputInvoiceConnection.DeleteInputInvoice(inputInvoiceModel);
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
        /// <param name="idInputInvoice"></param>
        /// <returns></returns>
        public static InputInvoiceModel SelectInputInvoiceById(string idInputInvoice)
        {
            try
            {
                string[] inputInvoice = new string[] { idInputInvoice };
                if (DataManagement.VerifyFields(inputInvoice))
                {
                    InputInvoiceModel inputInvoiceModel = new InputInvoiceModel()
                    {
                        IdInputInovice = int.Parse(idInputInvoice)
                    };
                    return InputInvoiceConnection.SelectInputInvoice(inputInvoiceModel);
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
        public static List<InputInvoiceModel> SelectAllInputInvoices()
        {
            try
            {
                return InputInvoiceConnection.SelectAllInputInvoice();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
