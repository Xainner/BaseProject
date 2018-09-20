using BusinessLibrary.Conection;
using BusinessLibrary.Models;
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
            string idCategory, 
            string idSubCategory,
            string normalPrice,
            string lowerPrice, 
            string estableQuantity, 
            string variableQuantity, 
            byte[] image,
            string ivi,
            string existingInvoice,
            string size
        )
        {
            try
            {
                string[] Product = new string[] {
                    code,
                    style,
                    idBrand,
                    description,
                    idCategory,
                    idSubCategory,
                    normalPrice,
                    lowerPrice,
                    estableQuantity,
                    variableQuantity,
                    ivi,
                    existingInvoice,
                    size
                };
                if (DataManagement.VerifyFields(Product))
                {
                    bool newIvi = true;
                    if (ivi == "0")
                    {
                        newIvi = false;
                    }
                    bool newExistingInvoice = true;
                    if (existingInvoice == "0")
                    {
                        newExistingInvoice = false;
                    }
                    ProductModel productModel = new ProductModel()
                    {
                        Code = int.Parse(code),
                        Style = style,
                        IdBrand = int.Parse(idBrand),
                        Description = description,
                        IdCategory = int.Parse(idCategory),
                        IdSubCategory = int.Parse(idSubCategory),
                        NormalPrice = decimal.Parse(normalPrice),
                        LowerPrice = decimal.Parse(lowerPrice),
                        EstableQuantity = int.Parse(estableQuantity),
                        VariableQuantity = int.Parse(variableQuantity),
                        Ivi = newIvi,
                        ExistingInvoice = newExistingInvoice,
                        Image = image

                    };
                    return ProductConnection.InsertProduct(productModel);
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
            string idCategory, 
            string idSubCategory,
            string normalPrice, 
            string lowerPrice, 
            string estableQuantity,
            string variableQuantity, 
            byte[] image,
            string ivi, 
            string existingInvoice, 
            string size
        )
        {
            try
            {
                string[] product = new string[] {
                    idProduct,
                    code,  style,
                    idBrand,
                    description,
                    idCategory,
                    idSubCategory,
                    normalPrice,
                    lowerPrice,
                    estableQuantity,
                    variableQuantity,
                    ivi,
                    existingInvoice,
                    size
                };
                if (DataManagement.VerifyFields(product))
                {
                    bool newIvi = true;
                    if (ivi == "0")
                    {
                        newIvi = false;
                    }
                    bool newExistingInvoice = true;
                    if (existingInvoice == "0")
                    {
                        newExistingInvoice = false;
                    }
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),
                        Code = int.Parse(code),
                        Style = style,
                        IdBrand = int.Parse(idBrand),
                        Description = description,
                        IdCategory = int.Parse(idCategory),
                        IdSubCategory = int.Parse(idSubCategory),
                        NormalPrice = decimal.Parse(normalPrice),
                        LowerPrice = decimal.Parse(lowerPrice),
                        EstableQuantity = int.Parse(estableQuantity),
                        VariableQuantity = int.Parse(variableQuantity),
                        Ivi = newIvi,
                        ExistingInvoice = newExistingInvoice,
                        Image = image

                    };
                    return ProductConnection.UpdateProduct(productModel);
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
                if (DataManagement.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),
                    };
                    return ProductConnection.UpdateProduct(productModel);
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
        public static bool SelectProductById(string idProduct)
        {
            try
            {
                string[] product = new string[] { idProduct };
                if (DataManagement.VerifyFields(product))
                {
                    ProductModel productModel = new ProductModel()
                    {
                        IdProduct = int.Parse(idProduct),

                    };
                    return ProductConnection.UpdateProduct(productModel);
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
                return ProductConnection.SelectAllProduct();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
