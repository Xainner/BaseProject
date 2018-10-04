using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class DetailApartModel
    {
        public int idDetailApart;
        public DateTime currentDate;
        public int idClient;
        public int idEmployee;
        public int idBusiness;
        public DateTime endDate;
        public decimal discount;
        public decimal subTotal;
        public decimal total;
        public string paymentType;
        public decimal currentPayment;
        public decimal ivi;
        public decimal residue;

        public int IdDetailApart { get => idDetailApart; set => idDetailApart = value; }
        public DateTime CurrentDate { get => currentDate; set => currentDate = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdBusiness { get => idBusiness; set => idBusiness = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public decimal Discount { get => discount; set => discount = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public decimal Total { get => total; set => total = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        public decimal CurrentPayment { get => currentPayment; set => currentPayment = value; }
        public decimal Ivi { get => ivi; set => ivi = value; }
        public decimal Residue { get => residue; set => residue = value; }
    }
}
