﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class InputInvoiceModel
    {
        public int idInputInovice;
        public List<ProductModel> products;
        public string date;
        public string provider;

        public int IdInputInovice { get => idInputInovice; set => idInputInovice = value; }
        public List<ProductModel> Products { get => products; set => products = value; }
        public string Date { get => date; set => date = value; }
        public string Provider { get => provider; set => provider = value; }
    }
}
