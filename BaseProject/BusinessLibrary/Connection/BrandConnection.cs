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
        public static BrandModel SelectBrand(BrandModel brand)
        {
            try
            {
                //brand = DBBrand.SelectBrand(brand);
                return brand;
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
                //DBBrand.SelectAllBrand();
                return null;
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
