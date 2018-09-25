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

namespace DataBaseLibrary
{
    public class DBBusiness
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

        // Business

        /// <summary>
        /// Show all Business in the table business
        /// </summary>
        /// <returns></returns>
        public static List<BusinessModel> SelectBusinessAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BusinessModel>("SELECT * FROM business");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific business by idBusiness
        /// </summary>
        /// <param name="Business"></param>
        /// <returns>output</returns>
        public static BusinessModel SelectBusinessId(BusinessModel Business)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<BusinessModel>("SELECT * FROM business WHERE idBusiness = @idBusiness", Business);
                return output;
            }
        }

        /// <summary>
        /// Insert a business from business
        /// </summary>
        /// <param name="Business"></param>
        public static void InsertBusiness(BusinessModel Business)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO business" +
                    "(fantasyName, societyName, legalCertification, Telephone, mainAddress, " +
                    "generalAddress, Email, webPage, Logo) VALUES" +
                    "(@fantasyName, @societyName, @legalCertification, @Telephone, @mainAddress, " +
                    "@generalAddress, @Email, @webPage, @Logo)", Business);
            }
        }

        /// <summary>
        /// Delete a business from business
        /// </summary>
        /// <param name="Business"></param>
        public static void DeleteBusiness(BusinessModel Business)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM business WHERE idBusiness = @idBusiness", Business);
            }
        }

        /// <summary>
        /// Update a business from business
        /// </summary>
        /// <param name="Business"></param>
        public static void UpdateBusiness(BusinessModel Business)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE business " +
                    "SET fantasyName = @fantasyName, Telephone = @Telephone, " +
                    "mainAddress = @mainAddress, generalAddress = @generalAddress, " +
                    "Email = @Email, webPage = @webPage, Logo = @Logo " +
                    "WHERE idBusiness = @idBusiness", Business);
            }
        }
    }
}
