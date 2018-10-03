using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class InvoiceInputExitModel
    {
        public int idNumInvoice;
        public int idProduct;
        public int quantity;

        public int IdNumInvoice { get => idNumInvoice; set => idNumInvoice = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
