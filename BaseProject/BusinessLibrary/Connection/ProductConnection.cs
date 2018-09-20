using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class ProductConnection
    {
        public static ProductModel SelectProduct(ProductModel product)
        {
            try
            {
                //product = DBProduct.SelectProduct(product);
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ProductModel> SelectAllProduct()
        {
            try
            {
                //DBProduct.SelectAllProduct();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertProduct(ProductModel product)
        {
            try
            {
                DBProduct.InsertProduct(product);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateProduct(ProductModel product)
        {
            try
            {
                //Cambiar el nombre de UpdateClient a Update product
                //DBProduct.UpdateProduct(product);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteProduct(ProductModel product)
        {
            try
            {
                DBProduct.DeleteProduct(product);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
