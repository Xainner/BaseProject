using BusinessLibrary.Models;
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
                //business = ClaseBD.SelectBusiness(business);
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
                //ClaseBD.SelectAllBusiness();
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
                //ClaseBD.InsertBusiness(business);
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
                //ClaseBD.UpdateBusiness(business);
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
                //ClaseBD.DeleteBusiness(business);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
