using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Connection
{
    public class InternalSellinvoiceConnection
    {
        public static InternalSellinvoiceModel SelectInternalSellinvoice(InternalSellinvoiceModel internalSellinvoice)
        {
            try
            {
                //internalSellinvoice = ClaseBD.SelectInternalSellinvoice(internalSellinvoice);
                return internalSellinvoice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<InternalSellinvoiceModel> SelectAllInternalSellinvoice()
        {
            try
            {
                //ClaseBD.SelectAllInternalSellinvoice();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertInternalSellinvoice(InternalSellinvoiceModel internalSellinvoice)
        {
            try
            {
                //ClaseBD.InsertInternalSellinvoice(internalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateInternalSellinvoice(InternalSellinvoiceModel internalSellinvoice)
        {
            try
            {
                //ClaseBD.UpdateInternalSellinvoice(internalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteInternalSellinvoice(InternalSellinvoiceModel internalSellinvoice)
        {
            try
            {
                //ClaseBD.DeleteInternalSellinvoice(internalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
