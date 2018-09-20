using BusinessLibrary.Models;
using DataBaseLibrary;
//using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class CategoryConnection
    {
        public static CategoryModel SelectCategory(CategoryModel category)
        {
            try
            {
                //return DBCategory.SelectCategoryName(category);
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<CategoryModel> SelectAllCategory()
        {
            try
            {
                return DBCategory.SelectCategoryAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertCategory(CategoryModel category)
        {
            try
            {
                DBCategory.InsertCategory(category);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateCategory(CategoryModel category)
        {
            try
            {
                DBCategory.UpdateCategory(category);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteCategory(CategoryModel category)
        {
            try
            {
                DBCategory.DeleteCategory(category);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
