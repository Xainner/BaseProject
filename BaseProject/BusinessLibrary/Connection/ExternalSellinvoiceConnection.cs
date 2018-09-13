using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Connection
{
    public class ExternalSellinvoiceConnection
    {
        public static ExternalSellinvoiceModel SelectExternalSellinvoice(ExternalSellinvoiceModel externalSellinvoice)
        {
            try
            {
                //externalSellinvoice = ClaseBD.SelectExternalSellinvoice(externalSellinvoice);
                return externalSellinvoice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ExternalSellinvoiceModel> SelectAllExternalSellinvoice()
        {
            try
            {
                //ClaseBD.SelectAllExternalSellinvoice();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertExternalSellinvoice(ExternalSellinvoiceModel externalSellinvoice)
        {
            try
            {
                //ClaseBD.InsertExternalSellinvoice(externalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateExternalSellinvoice(ExternalSellinvoiceModel externalSellinvoice)
        {
            try
            {
                //ClaseBD.UpdateExternalSellinvoice(externalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteExternalSellinvoice(ExternalSellinvoiceModel internalSellinvoice)
        {
            try
            {
                //ClaseBD.DeleteExternalSellinvoice(internalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
