using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;

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
                if (ValidateData.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        Name = name,
                    };
                    return DBCategory.InsertCategory(categoryModel);
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
                if (ValidateData.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        Name = name,
                        IdCategory = int.Parse(idCategory)
                    };
                    return DBCategory.UpdateCategory(categoryModel);
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
                if (ValidateData.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        IdCategory = int.Parse(idCategory)
                    };
                    return DBCategory.DeleteCategory(categoryModel);
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
        //public static CategoryModel SelectCategoryById(string idCategory)
        //{
        //    try
        //    {
        //        string[] category = new string[] { idCategory };
        //        if (ValidateData.VerifyFields(category))
        //        {
        //            CategoryModel categoryModel = new CategoryModel()
        //            {
        //                IdCategory = int.Parse(idCategory)
        //            };
        //            return DBCategory.S(categoryModel);
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log4Net
        //        return null;
        //    }
        //}

        public static CategoryModel SelectCategoryByName(string name)
        {
            try
            {
                string[] category = new string[] { name };
                if (ValidateData.VerifyFields(category))
                {
                    CategoryModel categoryModel = new CategoryModel()
                    {
                        Name = name
                    };
                    return DBCategory.SelectCategoryName(categoryModel);
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

        public static int SelectCategoryByNameId(string name)
        {
            try
            {
                return DBCategory.SelectCategoryId(name);
            }
            catch (Exception ex)
            {
                //Log4Net
                return 0;
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
                return DBCategory.SelectCategoryAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
