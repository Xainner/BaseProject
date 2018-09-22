using ModelLibrary.Models;
using System;
using System.Collections.Generic;

namespace BusinessLibrary.Connection
{
    public class InternalSellinvoiceConnection
    {
        public static InternalSellinvoiceModel SelectInternalSellinvoice(InternalSellinvoiceModel internalSellinvoice)
        {
            try
            {
                //internalSellinvoice = DBInternalSellinvoice.SelectInternalSellinvoice(internalSellinvoice);
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
                //DBInternalSellinvoice.SelectAllInternalSellinvoice();
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
                //DBInternalSellinvoice.InsertInternalSellinvoice(internalSellinvoice);
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
                //DBInternalSellinvoice.UpdateInternalSellinvoice(internalSellinvoice);
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
                //DBInternalSellinvoice.DeleteInternalSellinvoice(internalSellinvoice);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
