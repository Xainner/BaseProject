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
    public class DBDetailInvoiceInput
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

        /// <summary>
        /// show all invoice of input
        /// </summary>
        /// <param name="Detail"></param>
        /// <returns></returns>
        public static List<DetailInvoiceInput> SelectidDetailInvoiceInput(DetailInvoiceInput Detail)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DetailInvoiceInput>("SELECT * FROM detailinvoiceinput WHERE idDetailInvoiceInput = @idDetailInvoiceInput", Detail);
                return output.ToList();
            }
        }


    }
}
