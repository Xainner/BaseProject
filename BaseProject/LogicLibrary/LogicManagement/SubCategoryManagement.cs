using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;

namespace LogicLibrary
{
    public class SubCategoryManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idCategory"></param>
        /// <returns></returns>
        public static bool InsertSubCategory(string name, string idCategory)
        {
            try
            {
                string[] subCategory = new string[] { name, idCategory };
                if (ValidateData.VerifyFields(subCategory))
                {
                    SubCategoryModel subCategoryModel = new SubCategoryModel()
                    {
                        IdCategory = int.Parse(idCategory),
                        Name = name,
                    };
                    DBSubCategory.InsertSubCategory(subCategoryModel);
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

        public static bool UpdateSubCategoryById(string idSubCategory, string idCategory, string name)
        {
            try
            {
                string[] subCategory = new string[] { idSubCategory, name };
                if (ValidateData.VerifyFields(subCategory))
                {
                    SubCategoryModel subCategoryModel = new SubCategoryModel()
                    {
                        IdsubCategory = int.Parse(idSubCategory),
                        IdCategory = int.Parse(idCategory),
                        Name = name
                    };
                    DBSubCategory.UpdateSubCategory(subCategoryModel);
                    return true;
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


        public static bool DeleteSubCategoryById(string idSubCategory)
        {
            try
            {
                string[] subCategory = new string[] { idSubCategory };
                if (ValidateData.VerifyFields(subCategory))
                {
                    SubCategoryModel subCategoryModel = new SubCategoryModel()
                    {
                        IdsubCategory = int.Parse(idSubCategory)
                    };
                    return DBSubCategory.DeleteSubCategory(subCategoryModel);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSubCategory"></param>
        /// <returns></returns>
        public static SubCategoryModel SelectSubCategoryByName(string name)
        {
            try
            {
                string[] subCategory = new string[] { name };
                if (ValidateData.VerifyFields(subCategory))
                {
                    SubCategoryModel subCategoryModel = new SubCategoryModel()
                    {
                        Name = name
                    };
                    return DBSubCategory.SelectSubCategoryName(subCategoryModel);
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


        public static SubCategoryModel SelectSubCategoryById(string id)
        {
            try
            {
                string[] subCategory = new string[] { id };
                if (ValidateData.VerifyFields(subCategory))
                {
                    SubCategoryModel subCategoryModel = new SubCategoryModel()
                    {
                        IdsubCategory = int.Parse(id)
                    };
                    return DBSubCategory.SelectSubCategoryById(subCategoryModel);
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
        /// <param name="idSubCategory"></param>
        /// <returns></returns>
        public static List<SubCategoryModel> SelectCatWithSub(int idCategory)
        {
            try
            {
                SubCategoryModel subCategoryModel = new SubCategoryModel()
                {
                    IdCategory = idCategory,
                };
                return DBSubCategory.SelectCatWithSub(subCategoryModel);
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
        public static List<SubCategoryModel> SelectAllSubCategories()
        {
            try
            {
                return DBSubCategory.SelectSubCategoryAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
