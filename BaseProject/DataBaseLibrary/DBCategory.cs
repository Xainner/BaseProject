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
    public class DBCategory
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

        // Category

        /// <summary>
        /// Show all categories in the table category
        /// </summary>
        /// <returns>output</returns>
        public List<CategoryModel> SelectCategoryAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT * FROM category");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific category
        /// </summary>
        /// <param name="Category"></param>
        /// <returns>output</returns>
        public List<CategoryModel> SelectCategoryName(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT * FROM category WHERE idCategory = @idCategory", Category);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a category from category
        /// </summary>
        /// <param name="Category"></param>
        public static void InsertSCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO category(Name) VALUES(@Name)", Category);
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
                cnn.Execute("UPDATE category SET Name = @Name, " +
                    "idSubCategory = @idSubCategory WHERE idCategory = @idCategory", Category);
            }
        }
    }
}
