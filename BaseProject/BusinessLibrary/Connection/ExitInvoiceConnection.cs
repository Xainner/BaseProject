using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Connection
{
    public class ExitInvoiceConnection
    {
        public static ExitInvoiceModel SelectExitInvoice(ExitInvoiceModel exitInvoice)
        {
            try
            {
                //exitInvoice = DBExitInvoice.SelectExitInvoice(exitInvoice);
                return exitInvoice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ExitInvoiceModel> SelectAllExitInvoice()
        {
            try
            {
                //DBExitInvoice.SelectAllExitInvoice();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertExitInvoice(ExitInvoiceModel exitInvoice)
        {
            try
            {
                //DBExitInvoice.InsertExitInvoice(exitInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateExitInvoice(ExitInvoiceModel exitInvoice)
        {
            try
            {
                //DBExitInvoice.UpdateExitInvoice(exitInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteExitInvoice(ExitInvoiceModel exitInvoice)
        {
            try
            {
                //DBExitInvoice.DeleteExitInvoice(exitInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
