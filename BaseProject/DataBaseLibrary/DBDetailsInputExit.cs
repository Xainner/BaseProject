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
    public class DBDetailsInputExit
    {
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool InsertInputExitInvoice(InputExitDetaillsModel DetailsInputExit)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO detailinvoice (idEmployee, Provider, Destiny)" +
                        " VALUES(@idEmployee, @providerBusiness, @destinyBusiness)", DetailsInputExit);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<InputExitDetaillsModel> SelectInputExitInvoiceByEmployee(InputExitDetaillsModel DetailsInputExit)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM detailinvoice WHERE idEmployee = @idEmployee", DetailsInputExit);
                return output.ToList();
            }
        }

        public static List<InputExitDetaillsModel> SelectAllInputExitInvoice(InputExitDetaillsModel DetailsInputExit)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM detailinvoice", DetailsInputExit);
                return output.ToList();
            }
        }

        public static InputExitDetaillsModel SelectInputExitInvoiceByIdNum(InputExitDetaillsModel IdNum)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM detailinvoice WHERE idNumInvoice = @idNumInvoice", IdNum);
                return output.Single();
            }
        }

        public static InputExitDetaillsModel SelectDetailsInputExitID()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputExitDetaillsModel>("SELECT * FROM detailinvoice ORDER BY idNumInvoice DESC LIMIT 1");
                return output.Single();
            }
        }
    }
}
