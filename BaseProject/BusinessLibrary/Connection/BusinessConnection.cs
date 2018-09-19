using BusinessLibrary.Models;
using DataBaseLibrary;
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
                //business = DBBusiness.SelectBusiness(business);
                return business;
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
                //DBBusiness.SelectAllBusiness();
                return null;
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
