using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class CategoryModel
    {
        public int idCategory;
        public string name;

        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string Name { get => name; set => name = value; }
    }
}
