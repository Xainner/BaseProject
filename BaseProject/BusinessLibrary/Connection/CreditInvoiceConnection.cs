using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Connection
{
    public class CreditInvoiceConnection
    {
        public static CreditInvoiceModel SelectCreditInvoice(CreditInvoiceModel creditInvoice)
        {
            try
            {
                //creditInvoice = DBCreditInvoice.SelectCreditInvoice(creditInvoice);
                return creditInvoice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<CreditInvoiceModel> SelectAllCreditInvoice()
        {
            try
            {
                //DBCreditInvoice.SelectAllCreditInvoice();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertCreditInvoice(CreditInvoiceModel creditInvoice)
        {
            try
            {
                //DBCreditInvoice.InsertCreditInvoice(creditInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateCreditInvoice(CreditInvoiceModel creditInvoice)
        {
            try
            {
                //DBCreditInvoice.UpdateCreditInvoice(creditInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteCreditInvoice(CreditInvoiceModel creditInvoice)
        {
            try
            {
                //DBCreditInvoice.DeleteCreditInvoice(creditInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
