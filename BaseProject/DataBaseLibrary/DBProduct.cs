using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

using BusinessLibrary.Models;
using System.Configuration;

namespace DataBaseLibrary
{
    public class DBProduct
    {
        /// <summary>
        /// Make the connection with the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ConfigurationManager</returns>
        private static String LoadConnectionString(String id = "User")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // Product

        /// <summary>
        /// Show all products in the table product
        /// </summary>
        /// <returns>output</returns>
        public List<ProductModel> SelectProductAll()
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
        public List<ProductModel> SelectidProduct(ProductModel Product)
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
        public List<ProductModel> SelectCode(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE Code = @Code", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by Style
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public List<ProductModel> SelectStyle(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE Style = @Style", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by idBrand
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public List<ProductModel> SelectidBrand(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idBrand = @idBrand", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by idCategory
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public List<ProductModel> SelectidCategory(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM product WHERE idCategory = @idCategory", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific product by Description
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>output</returns>
        public List<ProductModel> SelectDescription(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>(
                    "SELECT * FROM product WHERE " +
                    "(Description = "+"%"+"@Description" + "%)", Product);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a product from product
        /// </summary>
        /// <param name="Product"></param>
        public static void InsertProduct(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO product" +
                    "(Code, Style, idBrand, Description, idCategory, " +
                    "normalPrice, lowerPrice, estableQuantity, variableQuantity, " +
                    "Image, Ivi, existingInvoice) VALUES" +
                    "(@Code, @Style, @idBrand, @Description, @idCategory, " +
                    "@normalPrice, @lowerPrice, @estableQuantity, @variableQuantity, " +
                    "@Image, @Ivi, @existingInvoice)", Product);
            }
        }

        /// <summary>
        /// Delete a product from product
        /// </summary>
        /// <param name="Product"></param>
        public static void DeleteProduct(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM product WHERE idProduct = @idProduct", Product);
            }
        }

        /// <summary>
        /// Update a product from product
        /// </summary>
        /// <param name="Product"></param>
        public static void UpdateClient(ProductModel Product)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE client " +
                    "SET Code = @Code, Style = @Style, idBrand = @idBrand, " +
                    "Description = @Description, idCategory = @idCategory, " +
                    "normalPrice = @normalPrice, lowerPrice = @lowerPrice, " +
                    "estableQuantity = @estableQuantity, " +
                    "variableQuantity = @variableQuantity, Image = @Image, " +
                    "Ivi = @Ivi, existingInvoice = @existingInvoice " +
                    "WHERE idProduct = @idProduct", Product);
            }
        }
    }
}
