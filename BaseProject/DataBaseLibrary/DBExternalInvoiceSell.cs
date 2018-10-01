using BusinessLibrary.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class DBExternalInvoiceSell
    {
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // BRAND

        /// <summary>
        /// Show all brands in the table brand
        /// </summary>
        /// <returns></returns>
        public static List<ExternalInvoiceSellModel> SelectAllExternalInvoiceProducts()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExternalInvoiceSellModel>("SELECT * FROM ExternalInvoiceSell");
                return output.ToList();
            }
        }

        public static ExternalInvoiceSellModel SelectExternalInvoiceProductsById(ExternalInvoiceSellModel externalInvoiceSellModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ExternalInvoiceSellModel>("SELECT * FROM ExternalInvoiceSell WHERE idDetailExternalInvoiceSell like @idDetailExternalInvoiceSell", externalInvoiceSellModel);

                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertExternalInvoiceSell(ExternalInvoiceSellModel externalInvoiceSellModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO ExternalInvoiceSell (idDetailExternalInvoiceSell, Product_idProduct1) VALUES(@idDetailExternalInvoiceSell, @Product_idProduct1)", externalInvoiceSellModel);
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
