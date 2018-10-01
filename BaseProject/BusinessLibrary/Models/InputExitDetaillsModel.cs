using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class InputExitDetaillsModel
    {
        public int idNumInvoice;
        public int numInvoice;
        public DateTime date;
        public int idEmployee;
        public int providerBusiness;
        public int destinyBusiness;

        public int IdNumInvoice { get => idNumInvoice; set => idNumInvoice = value; }
        public DateTime Date { get => date; set => date = value; }
        public int NumInvoice { get => numInvoice; set => numInvoice = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int ProviderBusiness { get => providerBusiness; set => providerBusiness = value; }
        public int DestinyBusiness { get => destinyBusiness; set => destinyBusiness = value; }
    }
}
