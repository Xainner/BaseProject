using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

using BusinessLibrary.Models;

namespace DataBaseLibrary
{
    public class DBBrand
    {
        /// <summary>
        /// Make the connection with the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static String LoadConnectionString(String id = "User")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // BRAND

        /// <summary>
        /// Show all brands in the table brand
        /// </summary>
        /// <returns></returns>
        public List<BrandModel> SelectBrandAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BrandModel>("SELECT * FROM brand");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific brand
        /// </summary>
        /// <param name="Brand"></param>
        /// <returns></returns>
        public List<BrandModel> SelectBrandName(BrandModel Brand)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BrandModel>("SELECT * FROM brand WHERE idBrand = @idBrand", Brand);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a brand en the table brand
        /// </summary>
        /// <param name="Brand"></param>
        public static void InsertBrand(BrandModel Brand)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO brand(Name) VALUES(@Name)", Brand);
            }
        }

        /// <summary>
        /// Delete a brand from brand
        /// </summary>
        /// <param name="Brand"></param>
        public static void DeleteBrand(BrandModel Brand)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM brand WHERE idBrand = @idBrand", Brand);
            }
        }

        /// <summary>
        /// Update a brand from brand
        /// </summary>
        /// <param name="Brand"></param>
        public static void UpdateBrand(BrandModel Brand)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE brand SET Name = @Name WHERE idBrand = @idBrand", Brand);
            }
        }
    }
}
