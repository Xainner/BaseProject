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
                    Ivi = decimal.Parse(ivi),
                    ExistingInvoice = false,
                    Image = image

                };
                if (VerifyFields(Product))
                {
                    return ProductConnection.InsertProduct(productModel);
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
                    Ivi = decimal.Parse(ivi),
                    ExistingInvoice = false,
                    Image = image

                };
                if (VerifyFields(product))
                {
                    return ProductConnection.UpdateProduct(productModel);
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
                ProductModel productModel = new ProductModel()
                {
                    IdProduct = int.Parse(idProduct),
                };
                if (VerifyFields(product))
                {
                    return ProductConnection.UpdateProduct(productModel);
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
                ProductModel productModel = new ProductModel()
                {
                    IdProduct = int.Parse(idProduct),

                };
                if (VerifyFields(product))
                {
                    return ProductConnection.UpdateProduct(productModel);
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

        public static List<ProductModel> SelectAllProducts()
        {
            try
            {
                return ProductConnection.SelectAllProduct();
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }
    }
}
