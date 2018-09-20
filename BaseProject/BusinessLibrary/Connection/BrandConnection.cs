using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class BrandConnection
    {
        public static List<BrandModel> SelectBrandName(BrandModel brand)
        {
            try
            {
                return DBBrand.SelectBrandName(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<BrandModel> SelectAllBrand()
        {
            try
            {
                return DBBrand.SelectBrandAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertBrand(BrandModel brand)
        {
            try
            {
                DBBrand.InsertBrand(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateBrand(BrandModel brand)
        {
            try
            {
                DBBrand.UpdateBrand(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteBrand(BrandModel brand)
        {
            try
            {
                DBBrand.DeleteBrand(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
