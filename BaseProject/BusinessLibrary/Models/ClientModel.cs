using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ClientModel
    {
        public int idClient;
        public string name;
        public string lastName;
        public string identificationType;
        public string identification;
        public string email;
        public string bornDate;
        public string registrationDate;

        public int IdClient { get => idClient; set => idClient = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastName; set => lastName = value; }
        public string IdentificationType { get => identificationType; set => identificationType = value; }
        public string Identification { get => identification; set => identification = value; }
        public string Email { get => email; set => email = value; }
        public string BornDate { get => bornDate; set => bornDate = value; }
        public string RegistrationDate { get => registrationDate; set => registrationDate = value; }
    }
}
