using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.LogicManagement
{
    public class InputExitInvoiceManagement
    {
        public static bool InsertInputExitInvoice(string idNumInvoice, string idProduct, string quantity)
        {
            try
            {
                InvoiceInputExitModel inputInvoiceModel = new InvoiceInputExitModel()
                {
                    IdNumInvoice = int.Parse(idNumInvoice),
                    IdProduct = int.Parse(idProduct),
                    Quantity = int.Parse(quantity)
                };
                return DBInputExitInvoice.InsertInputExitInvoice(inputInvoiceModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }
    }
}
