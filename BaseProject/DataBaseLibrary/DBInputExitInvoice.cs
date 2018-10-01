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

        public static bool InsertInputInvoice(InputExitDetaillsModel inputInvoice)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO DetailInvoice (idEmployee, Provider)" +
                        " VALUES(@idEmployee, @Provider)", inputInvoice);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool InsertExitInvoice(InputExitDetaillsModel inputInvoice)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO DetailInvoice (idEmployee, Destiny)" +
                        " VALUES(@idEmployee, @Destiny)", inputInvoice);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<InputExitDetaillsModel> SelectInputExitInvoiceByEmployee(InputExitDetaillsModel inputInvoice)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM DetailInvoice WHERE idEmployee = @idEmployee", inputInvoice);
                return output.ToList();
            }
        }

        public static List<InputExitDetaillsModel> SelectAllExitInvoice(InputExitDetaillsModel inputInvoice)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM DetailInvoice WHERE typeTransaction = @Salida", inputInvoice);
                return output.ToList();
            }
        }

        public static InputExitDetaillsModel SelectInputExitInvoiceByIdNum(InputExitDetaillsModel IdNum)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM DetailInvoice WHERE idNumInvoice = @idNumInvoice", IdNum);
                return output.Single();
            }
        }
    }
}
