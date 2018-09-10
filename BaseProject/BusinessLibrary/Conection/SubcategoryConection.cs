using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    class SubcategoryConection
    {
        public static List<SubcategoryModel> SelectSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.SelectSubcategory(subcategory);
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.InsertSubcategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.UpdateSubcategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.DeleteSubcategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
