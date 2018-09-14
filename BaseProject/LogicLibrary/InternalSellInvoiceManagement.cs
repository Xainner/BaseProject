using BusinessLibrary.Connection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class InternalSellInvoiceManagement
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
        public static bool InsertInternalSellinvoice(string numInvoice, string date, string idClient, string idEmployee, string idBusiness,
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
                InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
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
                    InternalSellinvoiceConnection.InsertInternalSellinvoice(internalSellinvoiceModel);
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

        public static bool UpdateInternalSellinvoiceById(string idInternalSellinvoice, string name)
        {
            try
            {
                string[] internalSell = new string[] { idInternalSellinvoice, name };
                InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idInternalSellinvoice),
                };
                if (VerifyFields(internalSell))
                {
                    InternalSellinvoiceConnection.UpdateInternalSellinvoice(internalSellinvoiceModel);
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

        public static bool DeleteInternalSellinvoiceById(string idInternalSellinvoice)
        {
            try
            {
                //TEMP
                string[] internalSell = new string[] { idInternalSellinvoice };
                InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idInternalSellinvoice)
                };
                if (VerifyFields(internalSell))
                {
                    InternalSellinvoiceConnection.DeleteInternalSellinvoice(internalSellinvoiceModel);
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

        public static InternalSellinvoiceModel SelectInternalSellinvoiceById(string idInternalSellinvoice)
        {
            try
            {
                //TEMP
                string[] internalSell = new string[] { idInternalSellinvoice };
                InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idInternalSellinvoice)
                };
                if (VerifyFields(internalSell))
                {
                    return InternalSellinvoiceConnection.SelectInternalSellinvoice(internalSellinvoiceModel);
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
