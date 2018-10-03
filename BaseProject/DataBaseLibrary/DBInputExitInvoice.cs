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
    public class DBInputExitInvoice
    {
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool InsertInputExitInvoice(InvoiceInputExitModel inputInvoice)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO InvoiceInputExit (idNumInvoice, idProduct, Quantity)" +
                        " VALUES(@idNumInvoice, @idProduct, @Quantity)", inputInvoice);
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
