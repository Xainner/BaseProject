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
                //creditInvoice = ClaseBD.SelectCreditInvoice(creditInvoice);
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
                //ClaseBD.SelectAllCreditInvoice();
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
                //ClaseBD.InsertCreditInvoice(creditInvoice);
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
                //ClaseBD.UpdateCreditInvoice(creditInvoice);
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
                //ClaseBD.DeleteCreditInvoice(creditInvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
