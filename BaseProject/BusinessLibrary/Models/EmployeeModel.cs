using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class EmployeeModel
    {
        public int idEmployee;
        public string name;
        public string lastName;
        public string identificationType;
        public string identification;
        public string residence;
        public DateTime bornDate;
        public string civilState;
        public string childs;
        public string telephone;
        public string cellphone;
        public string enterStore;
        public string nationality;
        public int idPosition;
        public string workingState;
        public DateTime enterDate;
        public DateTime endDate;
        public string observation;
        public byte[] image;
        public string nameEmergency;
        public string cellphoneEmergency;

        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string IdentificationType { get => identificationType; set => identificationType = value; }
        public string Identification { get => identification; set => identification = value; }
        public string Residence { get => residence; set => residence = value; }
        public DateTime BornDate { get => bornDate; set => bornDate = value; }
        public string CivilState { get => civilState; set => civilState = value; }
        public string Childs { get => childs; set => childs = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public string EnterStore { get => enterStore; set => enterStore = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public int IdPosition { get => idPosition; set => idPosition = value; }
        public string WorkingState { get => workingState; set => workingState = value; }
        public DateTime EnterDate { get => enterDate; set => enterDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Observation { get => observation; set => observation = value; }
        public byte[] Image { get => image; set => image = value; }
        public string NameEmergency { get => nameEmergency; set => nameEmergency = value; }
        public string CellphoneEmergency { get => cellphoneEmergency; set => cellphoneEmergency = value; }
    }
}
