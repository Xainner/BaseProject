﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class CreditInvoiceModel
    {
        public int idSellinvoice;
        public string numInvoice;
        public string date;
        public int idClient;
        public int idEmployee;
        public int idBusiness;
        public int idUser;
        //public List<ProductModel> products;
        public string coinType;
        public string paymentType;
        public string iviAmount;
        public string currencyType;
        public decimal paymentCash;
        public decimal totalDiscount;
        public decimal subTotal;
        public decimal total;
        public string range;
        public string interests;
        public decimal amountOfDues;
        public decimal cashDeposit;
        public decimal cardDeposit;
        public decimal inflation;

        public int IdSellinvoice { get => idSellinvoice; set => idSellinvoice = value; }
        public string NumInvoice { get => numInvoice; set => numInvoice = value; }
        public string Date { get => date; set => date = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdBusiness { get => idBusiness; set => idBusiness = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        //public List<ProductModel> Products { get => products; set => products = value; }
        public string CoinType { get => coinType; set => coinType = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        public string IviAmount { get => iviAmount; set => iviAmount = value; }
        public string CurrencyType { get => currencyType; set => currencyType = value; }
        public decimal PaymentCash { get => paymentCash; set => paymentCash = value; }
        public decimal TotalDiscount { get => totalDiscount; set => totalDiscount = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public decimal Total { get => total; set => total = value; }
        public string Range { get => range; set => range = value; }
        public string Interests { get => interests; set => interests = value; }
        public decimal AmountOfDues { get => amountOfDues; set => amountOfDues = value; }
        public decimal CashDeposit { get => cashDeposit; set => cashDeposit = value; }
        public decimal CardDeposit { get => cardDeposit; set => cardDeposit = value; }
        public decimal Inflation { get => inflation; set => inflation = value; }
    }
}
