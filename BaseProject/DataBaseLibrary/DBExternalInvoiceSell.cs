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

        public static List<ExternalSellinvoiceModel> SelectAllExternalInvoices()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExternalSellinvoiceModel>("SELECT * FROM detailexternalinvoicesell");
                return output.ToList();
            }
        }
    }
}
