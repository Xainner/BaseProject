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
    public class DBDetailExternalInvoiceSell
    {
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<DetailExternalSellinvoiceModel> SelectAllExternalInvoices()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DetailExternalSellinvoiceModel>("SELECT * FROM detailexternalinvoicesell");
                return output.ToList();
                //
            }
        }

        public static bool InsertExternalInvoice(DetailExternalSellinvoiceModel externalSellinvoiceModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO DetailExternalInvoiceSell(ActualDate, idClient, idEmployee, idBusiness, currencyType, iviAmount, cashDeposit, cardDeposit, totalDiscount, subTotal, Total) VALUES(" +
                        "@ActualDate, @idClient, @idEmployee, @idBusiness,@currencyType, @iviAmount, @cashDeposit, @cardDeposit,@totalDiscount, @subTotal, @Total)", externalSellinvoiceModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public static bool UpdateExternalInvoice(DetailExternalSellinvoiceModel externalSellinvoiceModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE  DetailExternalInvoiceSell SET (ActualDate, idClient, idEmployee, idBusiness, currencyType, iviAmount, cashDeposit, cardDeposit, totalDiscount, subTotal, Total) VALUES(" +
                        "@ActualDate, @idClient, @idEmployee, @idBusiness,@currencyType, @iviAmount, @cashDeposit, @cardDeposit,@totalDiscount, @subTotal, @Total)", externalSellinvoiceModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteExternalSellInvoice(DetailExternalSellinvoiceModel externalSellinvoiceModel)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE DetailExternalInvoiceSell WHERE NumberInvoice = @NumberInvoice)", externalSellinvoiceModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DetailExternalSellinvoiceModel SelectExternalInvoiceById(DetailExternalSellinvoiceModel externalSellinvoiceModel)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                  var output = cnn.QuerySingle<DetailExternalSellinvoiceModel>("SELECT * FROM DetailExternalInvoiceSell WHERE NumberInvoice = @NumberInvoice", externalSellinvoiceModel);
                  return output;
            }
        }
    }
}
