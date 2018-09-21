using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class BusinessModel
    {
        public int idBusiness;
        public string fantasyName;
        public string societyName;
        public string legalCertification;
        public string telephone;
        public string mainAddress;
        public string generalAddress;
        public string email;
        public string webPage;
        public string logo;

        public int IdBusiness { get => idBusiness; set => idBusiness = value; }
        public string FantasyName { get => fantasyName; set => fantasyName = value; }
        public string SocietyName { get => societyName; set => societyName = value; }
        public string LegalCertification { get => legalCertification; set => legalCertification = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string MainAddress { get => mainAddress; set => mainAddress = value; }
        public string GeneralAddress { get => generalAddress; set => generalAddress = value; }
        public string Email { get => email; set => email = value; }
        public string WebPage { get => webPage; set => webPage = value; }
        public string Logo { get => logo; set => logo = value; }
    }
}
