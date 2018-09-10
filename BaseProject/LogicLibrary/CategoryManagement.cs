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
                //TEMP
                if (VerifyFields(category))
                {
                    //BS.InsertCategory(user);
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
                //TEMP
                if (VerifyFields(category))
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

        public static bool DeleteCategoryById(string idCategory)
        {
            try
            {
                //TEMP
                string[] category = new string[] { idCategory };
                //TEMP
                if (VerifyFields(category))
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

        public static bool SelectCategoryById(string idCategory)
        {
            try
            {
                //TEMP
                string[] category = new string[] { idCategory };
                //TEMP
                if (VerifyFields(category))
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

        //public static CategoryModel SelectAllSalaries()
        //{
        //    try
        //    {
        //        //METHOD
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        Log4Net
        //    }
        //}
    }
}
