using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class BrandModel
    {
        public int idBrand;
        public string name;

        public int IdBrand { get => idBrand; set => idBrand = value; }
        public string Name { get => name; set => name = value; }
    }
}
