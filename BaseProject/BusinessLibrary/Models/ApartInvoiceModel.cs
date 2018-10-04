using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ApartInvoiceModel
    {
        public int idDetailApart;
        public int idProduct;
        public int quantity;

        public int IdDetailApart { get => idDetailApart; set => idDetailApart = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
