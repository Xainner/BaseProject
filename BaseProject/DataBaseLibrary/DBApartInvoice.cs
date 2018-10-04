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
    public class DBApartInvoice
    {
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool InsertApartInvoice(ApartInvoiceModel apartInvoice)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO apart (idDetailApart, idProduct, Quantity)" +
                        " VALUES(@idDetailApart, @idProduct, @Quantity)", apartInvoice);
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
