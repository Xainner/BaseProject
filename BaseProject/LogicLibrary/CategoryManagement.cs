using BusinessLibrary.Conection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class CategoryManagement
    {
        public static bool VerifyFields(string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    return false;
                }
            }
            return false;
        }

        public static bool InsertCategory(string name)
        {
            try
            {
                //TEMP
                string[] category = new string[] { name };
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name,
                };
                if (VerifyFields(category))
                {
                    CategoryConnection.InsertCategory(categoryModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool UpdateCategoryById(string idCategory, string name)
        {
            try
            {
                //TEMP
                string[] category = new string[] { idCategory, name };
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name,
                    IdCategoy = int.Parse(idCategory)
                };
                if (VerifyFields(category))
                {
                    CategoryConnection.UpdateCategory(categoryModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool DeleteCategoryById(string idCategory)
        {
            try
            {
                //TEMP
                string[] category = new string[] { idCategory };
                CategoryModel categoryModel = new CategoryModel()
                {
                    IdCategoy = int.Parse(idCategory)
                };
                if (VerifyFields(category))
                {
                    CategoryConnection.DeleteCategory(categoryModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static CategoryModel SelectCategoryById(string idCategory)
        {
            try
            {
                //TEMP
                string[] category = new string[] { idCategory };
                //TEMP
                CategoryModel categoryModel = new CategoryModel()
                {
                    IdCategoy = int.Parse(idCategory)
                };
                if (VerifyFields(category))
                {
                    return CategoryConnection.SelectCategory(categoryModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }

        public static List<CategoryModel> SelectAllCategories()
        {
            try
            {
                return CategoryConnection.SelectAllCategory();
                //METHOD
            }
            catch (Exception ex)
            {
                return null;
                //*Log4Net
            }
        }
    }
}
