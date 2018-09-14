using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class ProductModel
    {
        public int idProduct;
        public int code;
        public string style;
        public int idBrand;
        public string description;
        public int idCategory;
        public int idsubCategory;
        public decimal normalPrice;
        public decimal lowerPrice;
        public int estableQuantity;
        public int variableQuantity;
        public byte[] image;
        public bool ivi;
        public bool existingInvoice;

        public int Id { get => idProduct; set => idProduct = value; }
        public int Code { get => code; set => code = value; }
        public string Style { get => style; set => style = value; }
        public int IdBrand { get => idBrand; set => idBrand = value; }
        public string Description { get => description; set => description = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int IdSubCategory { get => idsubCategory; set => idsubCategory = value; }
        public decimal NormalPrice { get => normalPrice; set => normalPrice = value; }
        public decimal LowerPrice { get => lowerPrice; set => lowerPrice = value; }
        public int EstableQuantity { get => estableQuantity; set => estableQuantity = value; }
        public int VariableQuantity { get => variableQuantity; set => variableQuantity = value; }
        public byte[] Image { get => image; set => image = value; }
        public bool Ivi { get => ivi; set => ivi = value; }
        public bool ExistingInvoice { get => existingInvoice; set => existingInvoice = value; }
    }
}
