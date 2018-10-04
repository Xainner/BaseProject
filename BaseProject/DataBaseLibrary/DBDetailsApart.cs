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
    public class DBDetailsApart
    {

        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool InsertDetailApart(DetailApartModel detailApart)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO detailapart (idEmployee, idClient, idBusiness, endDate, Discount, subTotal, Total, paymentType, currentPayment, Ivi, Residue)" +
                        " VALUES(@idEmployee, @idClient, @idBusiness, @endDate, @discount, @subTotal, @total, @paymentType, @currentPayment, @ivi, @residue)", detailApart);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static DetailApartModel SelectDetailApartById(DetailApartModel detailApart)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DetailApartModel>("SELECT * FROM detailinvoice WHERE idDetailApart = @idDetailApart", detailApart);
                return output.Single();
            }
        }

        public static DetailApartModel SelectDetailsApartID()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DetailApartModel>("SELECT * FROM detailapart ORDER BY idDetailApart DESC LIMIT 1");
                return output.Single();
            }
        }

    }
}
