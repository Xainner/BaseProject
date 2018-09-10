using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class CategoryModel
    {
        public int idCategoy;
        public string name;

        public int IdCategoy { get => idCategoy; set => idCategoy = value; }
        public string Name { get => name; set => name = value; }
    }
}
