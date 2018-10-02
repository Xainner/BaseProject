using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.LogicManagement
{
    public class ExternalInvoiceSellManagement
    {
        public static bool InsertExternalInvoice(string idInvoice, string idProduct)
        {
            try
            {
                ExternalInvoiceSellModel externalInvoiceSellModel = new ExternalInvoiceSellModel()
                {
                    idDetailExternalInvoiceSell = int.Parse(idInvoice),
                    Product_idProduct1 = int.Parse(idProduct)
                };
                return DBExternalInvoiceSell.InsertExternalInvoiceSell(externalInvoiceSellModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
