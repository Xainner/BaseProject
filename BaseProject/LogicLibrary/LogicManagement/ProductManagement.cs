
using BusinessLibrary.Models;
using DataBaseLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ProductManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="style"></param>
        /// <param name="idBrand"></param>
        /// <param name="description"></param>
        /// <param name="idCategory"></param>
        /// <param name="idSubCategory"></param>
        /// <param name="normalPrice"></param>
        /// <param name="lowerPrice"></param>
        /// <param name="estableQuantity"></param>
        /// <param name="variableQuantity"></param>
        /// <param name="image"></param>
        /// <param name="ivi"></param>
        /// <param name="existingInvoice"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static bool InsertProduct(
            string code,
            string style,
            string idBrand,
            string description,
            string idSubCategory,
            string normalPrice,
            string lowerPrice,
            string estableQuantity,
            string variableQuantity,
            byte[] image,
            bool ivi,
            bool existingInvoice
        )
        {
            try
            {
                string[] Product = new string[] {
                    code,
                    style,
                    idBrand,
                    description,
                    idSubCategory,
                    normalPrice,
                    lowerPrice,
                    estableQuantity,
                    variableQuantity
                };
                if (ValidateData.VerifyFields(Product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        Code = code,
                        Style = style,
                        IdBrand = int.Parse(idBrand),
                        Description = description,
                        IdSubCategory = int.Parse(idSubCategory),
                        NormalPrice = decimal.Parse(normalPrice),
                        LowerPrice = decimal.Parse(lowerPrice),
                        EstableQuantity = int.Parse(estableQuantity),
                        VariableQuantity = int.Parse(variableQuantity),
                        Ivi = ivi,
                        ExistingInvoice = existingInvoice,
                        Image = image

                    };
                    return DBProduct.InsertProduct(productModel);
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
        /// <param name="idProduct"></param>
        /// <param name="code"></param>
        /// <param name="style"></param>
        /// <param name="idBrand"></param>
        /// <param name="description"></param>
        /// <param name="idCategory"></param>
        /// <param name="idSubCategory"></param>
        /// <param name="normalPrice"></param>
        /// <param name="lowerPrice"></param>
        /// <param name="estableQuantity"></param>
        /// <param name="variableQuantity"></param>
        /// <param name="image"></param>
        /// <param name="ivi"></param>
        /// <param name="existingInvoice"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static bool UpdateProductById(
            string idProduct,
            string code, string style,
            string idBrand,
            string description,
            string idSubCategory,
            string normalPrice,
            string lowerPrice,
            string estableQuantity,
            string variableQuantity,
            byte[] image,
            bool ivi,
            bool existingInvoice
        )
        {
            try
            {
                string[] product = new string[] {
                    idProduct,
                    code,  style,
                    idBrand,
                    description,
                    idSubCategory,
                    normalPrice,
                    lowerPrice,
                    estableQuantity,
                    variableQuantity
                };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),
                        Code = code,
                        Style = style,
                        IdBrand = int.Parse(idBrand),
                        Description = description,
                        IdSubCategory = int.Parse(idSubCategory),
                        NormalPrice = decimal.Parse(normalPrice),
                        LowerPrice = decimal.Parse(lowerPrice),
                        EstableQuantity = int.Parse(estableQuantity),
                        VariableQuantity = int.Parse(variableQuantity),
                        Ivi = ivi,
                        ExistingInvoice = existingInvoice,
                        Image = image

                    };
                    return DBProduct.UpdateProduct(productModel);
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
        /// <param name="idProduct"></param>
        /// <returns></returns>
        public static bool DeleteProductById(string idProduct)
        {
            try
            {
                string[] product = new string[] { idProduct };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),
                    };
                    return DBProduct.DeleteProduct(productModel);
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
        /// <param name="idProduct"></param>
        /// <returns></returns>
        public static ProductModel SelectProductById(string idProduct)
        {
            try
            {
                string[] product = new string[] { idProduct };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),

                    };
                    return DBProduct.SelectidProduct(productModel);
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
        /// <param name="code"></param>
        /// <returns></returns>
        public static ProductModel SelectProductByCode(string code)
        {
            try
            {
                string[] product = new string[] { code };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        Code = code,

                    };
                    return DBProduct.SelectCode(productModel);
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
        /// <param name="style"></param>
        /// <returns></returns>
        public static ProductModel SelectProductByStyle(string style)
        {
            try
            {
                string[] product = new string[] { style };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        Style = style,

                    };
                    return DBProduct.SelectStyle(productModel);
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
        /// <param name="idBrand"></param>
        /// <returns></returns>
        public static List<ProductModel> SelectProductByIdBrand(string idBrand)
        {
            try
            {
                string[] product = new string[] { idBrand };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdBrand = int.Parse(idBrand),

                    };
                    return DBProduct.SelectidBrand(productModel);
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

        public static List<ProductModel> SelectProductByIdSubCategory(string idSubCategory)
        {
            try
            {
                string[] product = new string[] { idSubCategory };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdSubCategory = int.Parse(idSubCategory),

                    };
                    return DBProduct.SelectidSubCategory(productModel);
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
        /// <param name="description"></param>
        /// <returns></returns>
        public static List<ProductModel> SelectProductByDescription(string description)
        {
            try
            {
                string[] product = new string[] { description };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        Description = description,
                    };
                    return DBProduct.SelectDescription(productModel);
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

        public static bool UpdateQuantity(string idProduct, string quantity)
        {
            try
            {
                string[] product = new string[] { idProduct, quantity };
                if (ValidateData.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),
                        variableQuantity = int.Parse(quantity)
                    };
                    return DBProduct.UpdateQuantity(productModel);
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
        /// <returns></returns>
        public static List<ProductModel> SelectAllProducts()
        {
            try
            {
                return DBProduct.SelectProductAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
