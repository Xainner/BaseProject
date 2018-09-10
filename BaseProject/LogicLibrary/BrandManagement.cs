using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BrandManagement
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

        public static bool InsertBrand(string name)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { name };
                //TEMP
                if (VerifyFields(brand))
                {
                    //BS.InsertBrand(user);
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

        public static bool UpdateBrandById(string idBrand, string name)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idBrand, name };
                //TEMP
                if (VerifyFields(brand))
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

        public static bool DeleteBrandById(string idBrand)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idBrand };
                //TEMP
                if (VerifyFields(brand))
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

        public static bool SelectBrandById(string idBrand)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idBrand };
                //TEMP
                if (VerifyFields(brand))
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

        //public static BrandModel SelectAllSalaries()
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
