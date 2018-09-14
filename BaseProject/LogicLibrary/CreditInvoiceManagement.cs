using BusinessLibrary.Connection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class CreditInvoiceManagement
    {
        public static bool VerifyFields(string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    return false;
                }
            }
            return false;
        }

        //INSERT
        public static bool InsertBrand(string numInvoice, string date, int idClient, int idEmployee,
         int idBusiness, int idUser, List<ProductModel> products, string coinType, string paymentType, string iviAmount,
         string currencyType, decimal paymentCash, decimal totalDiscount, decimal subTotal, decimal total,
         string range, string interests, decimal amountOfDues, decimal cashDeposit, decimal cardDeposit, decimal inflation)
        {
            try
            {
                string[] brand = new string[] { numInvoice,  date, coinType,  paymentType,  iviAmount,
          currencyType, range,  interests };
                CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                {
                    AmountOfDues = amountOfDues,
                    CardDeposit = cardDeposit,
                    CashDeposit = cashDeposit,
                    CoinType = coinType,
                    CurrencyType = currencyType,
                    Date = date,
                    IdBusiness = idBusiness,
                    IdClient = idClient,
                    IdEmployee = idEmployee,
                    IdUser = idUser,
                    Inflation = inflation,
                    Interests = interests,
                    IviAmount = iviAmount,
                    NumInvoice = numInvoice,
                    PaymentCash = paymentCash,
                    PaymentType = paymentType,
                    Products = products,
                    Range = range,
                    SubTotal = subTotal,
                    Total = total,
                    TotalDiscount = totalDiscount
                };
                if (VerifyFields(brand))
                {
                    CreditInvoiceConnection.InsertCreditInvoice(creditInvoiceModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool UpdateBrandById(string idSellinvoice, string numInvoice, string date, int idClient, int idEmployee,
         int idBusiness, int idUser, List<ProductModel> products, string coinType, string paymentType, string iviAmount,
         string currencyType, decimal paymentCash, decimal totalDiscount, decimal subTotal, decimal total,
         string range, string interests, decimal amountOfDues, decimal cashDeposit, decimal cardDeposit,decimal inflation)
        {
            try
            {
                string[] brand = new string[] {  idSellinvoice,  numInvoice,  date, coinType,  paymentType,  iviAmount,
          currencyType, range,  interests };
                CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                {
                    IdSellinvoice = int.Parse(idSellinvoice),
                    AmountOfDues = amountOfDues,
                    CardDeposit = cardDeposit,
                    CashDeposit = cashDeposit,
                    CoinType = coinType,
                    CurrencyType = currencyType,
                    Date = date,
                    IdBusiness = idBusiness,
                    IdClient = idClient,
                    IdEmployee = idEmployee,
                    IdUser = idUser,
                    Inflation = inflation,
                    Interests = interests,
                    IviAmount = iviAmount,
                    NumInvoice = numInvoice,
                    PaymentCash = paymentCash,
                    PaymentType = paymentType,
                    Products = products,
                    Range = range,
                    SubTotal = subTotal,
                    Total = total,
                    TotalDiscount = totalDiscount
                };
                if (VerifyFields(brand))
                {
                    CreditInvoiceConnection.UpdateCreditInvoice(creditInvoiceModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool DeleteCreditInvoiceById(string idSellinvoice)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idSellinvoice };
                CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                {
                    IdSellinvoice = int.Parse(idSellinvoice)
                };
                if (VerifyFields(brand))
                {
                    return CreditInvoiceConnection.DeleteCreditInvoice(creditInvoiceModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static CreditInvoiceModel SelecCreditInvoiceById(string idSellinvoice)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idSellinvoice };
                CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                {
                    IdSellinvoice = int.Parse(idSellinvoice)
                };
                if (VerifyFields(brand))
                {
                    return CreditInvoiceConnection.SelectCreditInvoice(creditInvoiceModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }

        public static List<CreditInvoiceModel> SelectAllBrands()
        {
            try
            {
                return CreditInvoiceConnection.SelectAllCreditInvoice();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
