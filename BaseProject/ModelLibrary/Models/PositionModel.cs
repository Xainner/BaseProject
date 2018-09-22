using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class PositionModel
    {
        public int idPosition;
        public string positionName;
        public int idSalary;

        public int IdPosition { get => idPosition; set => idPosition = value; }
        public string PositionName { get => positionName; set => positionName = value; }
        public int IdSalary { get => idSalary; set => idSalary = value; }
    }
}
