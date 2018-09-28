using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;


using ModelLibrary.Models;
using System.Configuration;
using MySql.Data.MySqlClient;
using BusinessLibrary.Models;

namespace DataBaseLibrary
{
    public class DBSubCategory
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
        public static SubCategoryModel SelectSubCategoryName(SubCategoryModel SubCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<SubCategoryModel>("SELECT * FROM subcategory WHERE Name = @Name", SubCategory);
                return output;
            }
        }

        /// <summary>
        /// return all the names of the subcategories with like by name
        /// </summary>
        /// <param name="SubCategory"></param>
        /// <returns></returns>
        public static List<SubCategoryModel> SelectSubCategoryNameLike(SubCategoryModel SubCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                SubCategory.Name += "%";
                var output = cnn.Query<SubCategoryModel>("SELECT * FROM subcategory WHERE Name LIKE @Name", SubCategory);
                return output.ToList();
            }
        }

        /// <summary>
        /// return all the names of the subcategories with like by name
        /// </summary>
        /// <param name="SubCategory"></param>
        /// <returns></returns>
        public static List<SubCategoryModel> SelectCatWithSub(int idCategory)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SubCategoryModel>("SELECT Name FROM subcategory WHERE idCategory = @idCategory", idCategory);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a subcategory from subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        public static bool InsertSubCategory(SubCategoryModel SubCategory)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO subcategory(Name, idCategory) VALUES(@Name, @idCategory)", SubCategory);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete a subcategory from subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        public static bool DeleteSubCategory(SubCategoryModel SubCategory)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM subcategory WHERE idSubCategory = @idSubCategory", SubCategory);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Update a subcategory from subcategory
        /// </summary>
        /// <param name="SubCategory"></param>
        public static bool UpdateSubCategory(SubCategoryModel SubCategory)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE subcategory SET Name = @Name WHERE idSubCategory = @idSubCategory", SubCategory);
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
