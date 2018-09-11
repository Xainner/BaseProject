using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class CategoryConnection
    {
        public static ClientModel SelectCategory(ClientModel category)
        {
            try
            {
                //category = ClaseBD.SelectCategory(category);
                return category;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<CategoryModel> SelectAllCategory(CategoryModel category)
        {
            try
            {
                //ClaseBD.SelectAllCategory(category);
                return null;
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
                //ClaseBD.InsertCategory(category);
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
                //ClaseBD.UpdateCategory(category);
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
                //ClaseBD.DeleteCategory(category);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
