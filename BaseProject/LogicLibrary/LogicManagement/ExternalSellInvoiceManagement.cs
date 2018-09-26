using BusinessLibrary.Models;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ExternalSellInvoiceManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numInvoice"></param>
        /// <param name="date"></param>
        /// <param name="idClient"></param>
        /// <param name="idEmployee"></param>
        /// <param name="idBusiness"></param>
        /// <param name="idUser"></param>
        /// <param name="products"></param>
        /// <param name="coinType"></param>
        /// <param name="paymentType"></param>
        /// <param name="iviAmount"></param>
        /// <param name="currencyType"></param>
        /// <param name="paymentCash"></param>
        /// <param name="totalDiscount"></param>
        /// <param name="subTotal"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static bool InsertExternalSellinvoice(
            string numInvoice,
            string date,
            string idClient,
            string idEmployee,
            string idBusiness,
            string idUser,
            string coinType,
            string paymentType,
            string iviAmount,
            string currencyType,
            string paymentCash,
            string totalDiscount,
            string subTotal,
            string total
        )
        {
            try
            {
                string[] externalSellinvoice = new string[] {
                    numInvoice,
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
                    total
                };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
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
                        SubTotal = decimal.Parse(subTotal),
                        Total = decimal.Parse(total),
                        TotalDiscount = decimal.Parse(totalDiscount)
                    };
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExternalSellinvoice"></param>
        /// <param name="numInvoice"></param>
        /// <param name="date"></param>
        /// <param name="idClient"></param>
        /// <param name="idEmployee"></param>
        /// <param name="idBusiness"></param>
        /// <param name="idUser"></param>
        /// <param name="products"></param>
        /// <param name="coinType"></param>
        /// <param name="paymentType"></param>
        /// <param name="iviAmount"></param>
        /// <param name="currencyType"></param>
        /// <param name="paymentCash"></param>
        /// <param name="totalDiscount"></param>
        /// <param name="subTotal"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static bool UpdateExternalSellinvoiceById(
            string idExternalSellinvoice,
            string numInvoice,
            string date,
            string idClient,
            string idEmployee,
            string idBusiness,
            string idUser,
            List<ProductModel> products,
            string coinType,
            string paymentType,
            string iviAmount,
            string currencyType,
            string paymentCash,
            string totalDiscount,
            string subTotal,
            string total
        )
        {
            try
            {
                string[] externalSellinvoice = new string[] {
                    idExternalSellinvoice,
                    numInvoice,
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
                    total
                };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idExternalSellinvoice),
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExternalSellinvoice"></param>
        /// <returns></returns>
        public static bool DeleteExternalSellinvoiceById(string idExternalSellinvoice)
        {
            try
            {
                string[] externalSellinvoice = new string[] { idExternalSellinvoice };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idExternalSellinvoice)
                    };
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idExternalSellinvoice"></param>
        /// <returns></returns>
        public static ExternalSellinvoiceModel SelectExternalSellinvoiceById(string idExternalSellinvoice)
        {
            try
            {
                string[] externalSellinvoice = new string[] { idExternalSellinvoice };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    ExternalSellinvoiceModel internalSellinvoiceModel = new ExternalSellinvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idExternalSellinvoice)
                    };
                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ExternalSellinvoiceModel> SelectAllExternalSellinvoice()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
