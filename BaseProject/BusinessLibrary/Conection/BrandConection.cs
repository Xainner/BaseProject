using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    class BrandConection
    {
        public static List<BrandModel> SelectBrand(BrandModel brand)
        {
            try
            {
                //ClaseBD.SelectBrand(brand);
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
                //ClaseBD.InsertBrand(brand);
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
                //ClaseBD.UpdateBrand(brand);
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
                //ClaseBD.DeleteBrand(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
