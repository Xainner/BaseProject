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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool InsertCategory(string name)
        {
            try
            {
                string[] category = new string[] { name };
                if (DataManagement.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        Name = name,
                    };
                    return CategoryConnection.InsertCategory(categoryModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool UpdateCategoryById(string idCategory, string name)
        {
            try
            {
                //TEMP
                string[] category = new string[] { idCategory, name };
                if (DataManagement.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        Name = name,
                        IdCategoy = int.Parse(idCategory)
                    };
                    return CategoryConnection.UpdateCategory(categoryModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <returns></returns>
        public static bool DeleteCategoryById(string idCategory)
        {
            try
            {
                string[] category = new string[] { idCategory };
                if (DataManagement.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        IdCategoy = int.Parse(idCategory)
                    };
                    return CategoryConnection.DeleteCategory(categoryModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <returns></returns>
        public static CategoryModel SelectCategoryById(string idCategory)
        {
            try
            {
                string[] category = new string[] { idCategory };
                if (DataManagement.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        IdCategoy = int.Parse(idCategory)
                    };
                    return CategoryConnection.SelectCategory(categoryModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<CategoryModel> SelectAllCategories()
        {
            try
            {
                return CategoryConnection.SelectAllCategory();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
