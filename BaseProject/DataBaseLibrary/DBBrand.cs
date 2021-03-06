﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

using System.Windows.Forms;
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
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // BRAND

        /// <summary>
        /// Show all brands in the table brand
        /// </summary>
        /// <returns></returns>
        public static List<BrandModel> SelectBrandAll()
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
        public static List<BrandModel> SelectBrandName(BrandModel Brand)
        {
            try
            {
                Brand.Name += "%";
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BrandModel>("SELECT * FROM brand WHERE Name like @Name", Brand);

                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Brand.Name = ex.Message;
                List<BrandModel> list = new List<BrandModel> { Brand };
                return list;
            }
        }

        /// <summary>
        /// Return all brands for a combobox
        /// </summary>
        /// <param name="Brand"></param>
        /// <returns></returns>
        public static List<BrandModel> SelectAllBrandName(BrandModel Brand)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BrandModel>("SELECT Name FROM brand WHERE Name = @Name", Brand);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Brand.Name = ex.Message;
                List<BrandModel> list = new List<BrandModel> { Brand };
                return list;
            }
        }

        /// <summary>
        /// Insert a brand en the table brand
        /// </summary>
        /// <param name="Brand"></param>
        public static bool InsertBrand(BrandModel Brand)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO brand(Name) VALUES(@Name)", Brand);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete a brand from brand
        /// </summary>
        /// <param name="Brand"></param>
        public static bool DeleteBrand(BrandModel Brand)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM brand WHERE idBrand = @idBrand", Brand);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Update a brand from brand
        /// </summary>
        /// <param name="Brand"></param>
        public static bool UpdateBrand(BrandModel Brand)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE brand SET Name = @Name WHERE idBrand = @idBrand", Brand);
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
