using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class SubCategoryModel
    {
        public int idsubCategory;
        public string name;
        public int idCategory;

        public int IdsubCategory { get => idsubCategory; set => idsubCategory = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
    }
}
