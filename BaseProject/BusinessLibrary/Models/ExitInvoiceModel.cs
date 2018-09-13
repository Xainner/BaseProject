using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ExitInvoiceModel
    {
        public int idInputInvoice;
        public int idBusiness;
        public List<ProductModel> products;
        public string date;
        public string destiny;

        public int IdInputInovice { get => idInputInvoice; set => idInputInvoice = value; }
        public int IdBusiness { get => idBusiness; set => idBusiness = value; }
        public List<ProductModel> Products { get => products; set => products = value; }
        public string Date { get => date; set => date = value; }
        public string Destiny { get => destiny; set => destiny = value; }
    }
}
