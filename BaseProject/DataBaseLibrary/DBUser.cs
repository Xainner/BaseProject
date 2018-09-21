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
    public class DBUser
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

        // User

        /// <summary>
        /// Show all users in the table user
        /// </summary>
        /// <returns>output</returns>
        public static List<UserModel> SelectUserAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM user");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific user by idUser
        /// </summary>
        /// <param name="User"></param>
        /// <returns>output</returns>
        public static List<UserModel> SelectidUser(UserModel User)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM user WHERE idUser = @idUser", User);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific user by userName
        /// </summary>
        /// <param name="User"></param>
        /// <returns>output</returns>
        public static List<UserModel> SelectUserName(UserModel User)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>(
                    "SELECT * FROM user WHERE (userName = @userName)", User);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a user from user
        /// </summary>
        /// <param name="User"></param>
        public static void InsertUser(UserModel User)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO user" +
                    "(userName, Password, idEmployee) VALUES" +
                    "(@userName, @Password, @idEmployee)", User);
            }
        }

        /// <summary>
        /// Delete a user from user
        /// </summary>
        /// <param name="User"></param>
        public static void DeleteUser(UserModel User)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM user WHERE idUser = @idUser", User);
            }
        }

        /// <summary>
        /// Update a user from user
        /// </summary>
        /// <param name="User"></param>
        public static void UpdateUser(UserModel User)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE user " +
                    "SET Password = @Password WHERE idUser = @idUser", User);
            }
        }
    }
}
