using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class SubcategoryModel
    {
        public int idsubCategory;
        public int name;
        public int idCategory;

        public int IdsubCategory { get => idsubCategory; set => idsubCategory = value; }
        public int Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
    }
}
