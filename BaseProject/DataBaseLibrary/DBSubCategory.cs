using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;


using BusinessLibrary.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DataBaseLibrary
{
    public class DBSubCategory
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

        // SubCategory

        /// <summary>
        /// Show all subcategories in the table subcategory
        /// </summary>
        /// <returns></returns>
        public static List<SubCategoryModel> SelectSubCategoryAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        /// <returns></returns>
        public static List<SubCategoryModel> SelectSubCategoryName(SubCategoryModel SubCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory WHERE idSubCategory = @idSubCategory", SubCategory);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a subcategory from subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        public static void InsertSubCategory(SubCategoryModel SubCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO subcategory(Name) VALUES(@Name)", SubCategory);
            }
        }

        /// <summary>
        /// Delete a subcategory from subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        public static void DeleteSubCategory(SubCategoryModel SubCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM subcategory WHERE idSubCategory = @idSubCategory", SubCategory);
            }
        }

        /// <summary>
        /// Update a subcategory from subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        public static void UpdateSubCategory(SubCategoryModel SubCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE subcategory SET Name = @Name WHERE idSubCategory = @idSubCategory", SubCategory);
            }
        }
    }
}
