using BusinessLibrary.Models;
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
                //inputInvoice = ClaseBD.SelectInputInvoice(inputInvoice);
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
                //ClaseBD.SelectAllInputInvoice();
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
                //ClaseBD.InsertInputInvoice(inputInvoice);
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
                //ClaseBD.UpdateInputInvoice(inputInvoice);
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
                //ClaseBD.DeleteInputInvoice(inputInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
