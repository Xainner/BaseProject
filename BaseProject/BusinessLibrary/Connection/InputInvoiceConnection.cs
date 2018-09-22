
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Connection
{
    public class InputInvoiceConnection
    {
        public static InputInvoiceModel SelectInputInvoice(InputInvoiceModel inputInvoice)
        {
            try
            {
                //inputInvoice = DBInputInvoice.SelectInputInvoice(inputInvoice);
                return inputInvoice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<InputInvoiceModel> SelectAllInputInvoice()
        {
            try
            {
                //DBInputInvoice.SelectAllInputInvoice();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertInputInvoice(InputInvoiceModel inputInvoice)
        {
            try
            {
                //DBInputInvoice.InsertInputInvoice(inputInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateInputInvoice(InputInvoiceModel inputInvoice)
        {
            try
            {
                //DBInputInvoice.UpdateInputInvoice(inputInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteInputInvoice(InputInvoiceModel inputInvoice)
        {
            try
            {
                //DBInputInvoice.DeleteInputInvoice(inputInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
