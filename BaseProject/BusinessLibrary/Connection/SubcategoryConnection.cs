using BusinessLibrary.Models;
using DataBaseLibrary;
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
                //subcategory = DBSubCategory.SelectSubCategory(subcategory);
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
                //DBSubCategory.SelectAllSubCategory();
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
                DBSubCategory.InsertSubCategory(subcategory);
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
                DBSubCategory.UpdateSubCategory(subcategory);
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
                DBSubCategory.DeleteSubCategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
