using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

using ModelLibrary.Models;
using System.Configuration;
using BusinessLibrary.Models;

namespace DataBaseLibrary
{
    public class DBProduct
    {
        /// <summary>
        /// Make the connection with the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ConfigurationManager</returns>
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // Product

        /// <summary>
        /// Show all products in the table product
        /// </summary>
        /// <returns>output</returns>
        public static List<ProductModel> SelectProductAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by idProduct
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public static List<ProductModel> SelectidProduct(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idProduct = @idProduct", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by Code
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public static ProductModel SelectCode(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE Code = @Code", Product);
                return output.Single();
            }
        }

        /// <summary>
        /// Show a specific product by Style
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public static ProductModel SelectStyle(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE Style = @Style", Product);
                return output.Single();
            }
        }

        /// <summary>
        /// Show a specific product by idBrand
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public static List<ProductModel> SelectidBrand(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idBrand = @idBrand", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by Description
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public static List<ProductModel> SelectDescription(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                string description = "";
                description = Product.Description;
                description = "%" + description + "%";
                Product.Description = description;
                var output = cnn.Query<ProductModel>(
                    "SELECT * FROM product WHERE " +
                    "(Description like @Description)", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a product from product
        /// </summary>
        /// <param name="Product"></param>
        public static bool InsertProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO product" +
                        "(Code, Style, idBrand, idsubCategory, Description, " +
                        "normalPrice, lowerPrice, estableQuantity, variableQuantity, " +
                        "Image, Ivi, existingInvoice) VALUES" +
                        "(@Code, @Style, @idBrand, @idsubCategory, @Description, " +
                        "@normalPrice, @lowerPrice, @estableQuantity, @variableQuantity, " +
                        "@Image, @Ivi, @existingInvoice)", Product);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete a product from product
        /// </summary>
        /// <param name="Product"></param>
        public static bool DeleteProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM product WHERE idProduct = @idProduct", Product);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Update a product from product
        /// </summary>
        /// <param name="Product"></param>
        public static bool UpdateProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE product " +
                        "SET Code = @Code, Style = @Style, idBrand = @idBrand, " +
                        "idsubCategory = @idsubCategory, " +
                        "Description = @Description, " +
                        "normalPrice = @normalPrice, lowerPrice = @lowerPrice, " +
                        "estableQuantity = @estableQuantity, " +
                        "variableQuantity = @variableQuantity, Image = @Image, " +
                        "Ivi = @Ivi, existingInvoice = @existingInvoice " +
                        "WHERE idProduct = @idProduct", Product);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
