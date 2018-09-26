using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class ExitInvoiceModel
    {
        public int idExitInvoice;
        public int idBusiness;
        //public List<ProductModel> products;
        public string date;
        public string destiny;

        public int IdExitInvoice { get => idExitInvoice; set => idExitInvoice = value; }
        public int IdBusiness { get => idBusiness; set => idBusiness = value; }
        //public List<ProductModel> Products { get => products; set => products = value; }
        public string Date { get => date; set => date = value; }
        public string Destiny { get => destiny; set => destiny = value; }
    }
}
