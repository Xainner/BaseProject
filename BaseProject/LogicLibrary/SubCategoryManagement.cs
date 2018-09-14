using BusinessLibrary.Conection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class SubCategoryManagement
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

        public static bool InsertSubCategory(string name)
        {
            try
            {
                //TEMP
                string[] subCategory = new string[] { name };
                //TEMP
                if (VerifyFields(subCategory))
                {
                    //BS.InsertSubCategory(user);
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

        public static bool UpdateSubCategoryById(string idSubCategory, string name)
        {
            try
            {
                //TEMP
                string[] subCategory = new string[] { idSubCategory, name };
                //TEMP
                if (VerifyFields(subCategory))
                {
                    //METHOD
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

        public static bool DeleteSubCategoryById(string idSubCategory)
        {
            try
            {
                //TEMP
                string[] subCategory = new string[] { idSubCategory };
                //TEMP
                if (VerifyFields(subCategory))
                {
                    //METHOD
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

        public static bool SelectSubCategoryById(string idSubCategory)
        {
            try
            {
                //TEMP
                string[] subCategory = new string[] { idSubCategory };
                //TEMP
                if (VerifyFields(subCategory))
                {
                    //METHOD
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

        public static List<SubcategoryModel> SelectAllSubCategories()
        {
            try
            {
                return SubcategoryConnection.SelectAllSubcategory();
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }
    }
}
