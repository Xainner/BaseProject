using BusinessLibrary.Models;
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
                //product = ClaseBD.SelectProduct(product);
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
                //ClaseBD.SelectAllProduct();
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
                //ClaseBD.InsertProduct(position);
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
                //ClaseBD.UpdateProduct(position);
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
                //ClaseBD.DeleteProduct(position);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
