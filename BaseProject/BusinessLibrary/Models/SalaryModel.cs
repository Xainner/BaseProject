using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class SalaryModel
    {
        public int idSalary;
        public decimal salaryAmount;
        public string registrationDate;

        public int IdSalary { get => idSalary; set => idSalary = value; }
        public decimal SalaryAmount { get => salaryAmount; set => salaryAmount = value; }
        public string RegistrationDate { get => registrationDate; set => registrationDate = value; }
    }
}
