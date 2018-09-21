using DataBaseLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class BusinessConnection
    {
        public static BusinessModel SelectBusiness(BusinessModel business)
        {
            try
            {
                //return DBBusiness.SelectBusinessId(business);
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<BusinessModel> SelectAllBusiness()
        {
            try
            {
                return DBBusiness.SelectBusinessAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertBusiness(BusinessModel business)
        {
            try
            {
                DBBusiness.InsertBusiness(business);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateBusiness(BusinessModel business)
        {
            try
            {
                DBBusiness.UpdateBusiness(business);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteBusiness(BusinessModel business)
        {
            try
            {
                DBBusiness.DeleteBusiness(business);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
