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
        public static bool InsertInputExitInvoice(string idNumInvoice, string idProduct)
        {
            try
            {
                InvoiceInputExitModel inputInvoiceModel = new InvoiceInputExitModel()
                {
                    IdNumInvoice = int.Parse(idNumInvoice),
                    IdProduct = int.Parse(idProduct)
                };
                return true;
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }
    }
}
