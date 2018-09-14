using BusinessLibrary.Connection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ExternalSellInvoiceManagement
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
        public static bool InsertExternalSellinvoice(string numInvoice, string date, string idClient, string idEmployee, string idBusiness,
          string idUser, List<ProductModel> products, string coinType, string paymentType, string iviAmount, string currencyType,
          string paymentCash, string totalDiscount, string subTotal, string total)
        {
            try
            {
                string[] internalSell = new string[] {   numInvoice,
          date,
          idClient,
          idEmployee,
          idBusiness,
          idUser,
          coinType,
          paymentType,
          iviAmount,
          currencyType,
          paymentCash,
          totalDiscount,
          subTotal,
          total, };
                ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                {
                    IdClient = int.Parse(idClient),
                    IdBusiness = int.Parse(idBusiness),
                    Date = date,
                    CoinType = coinType,
                    CurrencyType = coinType,
                    IdEmployee = int.Parse(idEmployee),
                    IdUser = int.Parse(idUser),
                    IviAmount = iviAmount,
                    NumInvoice = numInvoice,
                    PaymentCash = decimal.Parse(paymentCash),
                    PaymentType = paymentType,
                    Products = products,
                    SubTotal = decimal.Parse(subTotal),
                    Total = decimal.Parse(total),
                    TotalDiscount = decimal.Parse(totalDiscount)
                };
                if (VerifyFields(internalSell))
                {
                    ExternalSellinvoiceConnection.InsertExternalSellinvoice(internalSellinvoiceModel);
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

        public static bool UpdateExternalSellinvoiceById(string idExternalSellinvoice, string name)
        {
            try
            {
                string[] internalSell = new string[] { idExternalSellinvoice, name };
                ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idExternalSellinvoice),
                };
                if (VerifyFields(internalSell))
                {
                    ExternalSellinvoiceConnection.UpdateExternalSellinvoice(internalSellinvoiceModel);
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

        public static bool DeleteExternalSellinvoiceById(string idExternalSellinvoice)
        {
            try
            {
                //TEMP
                string[] internalSell = new string[] { idExternalSellinvoice };
                ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idExternalSellinvoice)
                };
                if (VerifyFields(internalSell))
                {
                    ExternalSellinvoiceConnection.DeleteExternalSellinvoice(internalSellinvoiceModel);
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

        public static ExternalSellinvoiceModel SelectExternalSellinvoiceById(string idExternalSellinvoice)
        {
            try
            {
                //TEMP
                string[] internalSell = new string[] { idExternalSellinvoice };
                ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idExternalSellinvoice)
                };
                if (VerifyFields(internalSell))
                {
                    return ExternalSellinvoiceConnection.SelectExternalSellinvoice(internalSellinvoiceModel);
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
    }
}
