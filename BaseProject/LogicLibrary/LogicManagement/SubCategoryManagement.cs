using BusinessLibrary.Conection;

using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    SubcategoryConnection.InsertSubcategory(subCategoryModel);
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
                    SubcategoryConnection.UpdateSubcategory(subCategoryModel);
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
                    return SubcategoryConnection.DeleteSubcategory(subCategoryModel);
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
        public static SubCategoryModel SelectSubCategoryById(string idSubCategory)
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
                    return SubcategoryConnection.SelectSubcategory(subCategoryModel);
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
        public static List<SubCategoryModel> SelectAllSubCategories()
        {
            try
            {
                return SubcategoryConnection.SelectAllSubcategory();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
