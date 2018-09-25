﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

using ModelLibrary.Models;
using System.Configuration;

namespace DataBaseLibrary
{
    public class DBCategory
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

        // Category

        /// <summary>
        /// Show all categories in the table category
        /// </summary>
        /// <returns>output</returns>
        public static List<CategoryModel> SelectCategoryAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT * FROM category");
                List<CategoryModel> categoryModels = output.ToList();
                return categoryModels;
            }
        }

        /// <summary>
        /// Show a specific category by name
        /// </summary>
        /// <param name="Category"></param>
        /// <returns>output</returns>
        public static CategoryModel SelectCategoryName(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<CategoryModel>("SELECT * FROM category WHERE Name = @Name", Category);
                return output;
            }
        }

        /// <summary>
        /// return all categories by like name
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        public static List<CategoryModel> SelectCategoryNameLike(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                Category.Name += "%";
                var output = cnn.Query<CategoryModel>("SELECT * FROM category WHERE Name LIKE @Name", Category);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a category from category
        /// </summary>
        /// <param name="Category"></param>
        public static void InsertCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO category(Name) VALUES" +
                    "(@Name)", Category);
            }
        }

        /// <summary>
        /// Delete a category from category
        /// </summary>
        /// <param name="Category"></param>
        public static void DeleteCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM category WHERE idCategory = @idCategory", Category);
            }
        }

        /// <summary>
        /// Update a category from category
        /// </summary>
        /// <param name="Category"></param>
        public static void UpdateCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE category SET Name = @Name " +
                    " WHERE idCategory = @idCategory", Category);
            }
        }
    }
}
