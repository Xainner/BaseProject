using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.LogicManagement
{
    public class ApartInvoiceManagement
    {
        public static bool InsertApartInvoice(string idDetailApart, string idProduct, string quantity)
        {
            try
            {
                ApartInvoiceModel inputInvoiceModel = new ApartInvoiceModel()
                {
                    IdDetailApart = int.Parse(idDetailApart),
                    IdProduct = int.Parse(idProduct),
                    Quantity = int.Parse(quantity)
                };
                return DBApartInvoice.InsertApartInvoice(inputInvoiceModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }
    }
}
