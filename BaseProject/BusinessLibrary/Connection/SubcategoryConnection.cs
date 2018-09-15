using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class SubcategoryConnection
    {
        public static SubCategoryModel SelectSubcategory(SubCategoryModel subcategory)
        {
            try
            {
                //subcategory = ClaseBD.SelectSubcategory(subcategory);
                return subcategory;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SubCategoryModel> SelectAllSubcategory()
        {
            try
            {
                //ClaseBD.SelectAllSubcategory();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertSubcategory(SubCategoryModel subcategory)
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

        public static bool UpdateSubcategory(SubCategoryModel subcategory)
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

        public static bool DeleteSubcategory(SubCategoryModel subcategory)
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
