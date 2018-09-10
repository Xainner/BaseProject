using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ProductManagement
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

        public static bool InsertProduct(string code, string style, string idBrand, string description, string idCategory, string idSubCategory,
            string normalPrice, string lowerPrice, string estableQuantity, string variableQuantity, byte[] image,
            string ivi, string existingInvoice, string size)
        {
            try
            {
                //TEMP
                string[] Product = new string[] { code,  style,  idBrand,  description,  idCategory,  idSubCategory,
                                                    normalPrice,  lowerPrice,  estableQuantity,  variableQuantity, ivi,
                                                    existingInvoice,  size };
                //TEMP
                if (VerifyFields(Product))
                {
                    //BS.InsertSalary(user);
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

        public static bool UpdateProductById(string idProduct, string code, string style, string idBrand, string description, string idCategory, string idSubCategory,
            string normalPrice, string lowerPrice, string estableQuantity, string variableQuantity, byte[] image,
            string ivi, string existingInvoice, string size)
        {
            try
            {
                //TEMP
                string[] product = new string[] { idProduct, code,  style,  idBrand,  description,  idCategory,  idSubCategory,
                                                    normalPrice,  lowerPrice,  estableQuantity,  variableQuantity, ivi,
                                                    existingInvoice,  size };
                //TEMP
                if (VerifyFields(product))
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

        public static bool DeleteProductById(string idProduct)
        {
            try
            {
                //TEMP
                string[] product = new string[] { idProduct };
                //TEMP
                if (VerifyFields(product))
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

        public static bool SelectProductById(string idProduct)
        {
            try
            {
                //TEMP
                string[] product = new string[] { idProduct };
                //TEMP
                if (VerifyFields(product))
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

        //public static ProductModel SelectAllSalaries()
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
