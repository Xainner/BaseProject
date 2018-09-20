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
        public static bool InsertInternalSellinvoice(
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
                string[] internalSell = new string[] {
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
                if (DataManagement.VerifyFields(internalSell))
                {
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
                    return InternalSellinvoiceConnection.InsertInternalSellinvoice(internalSellinvoiceModel);
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
        /// <param name="idInternalSellinvoice"></param>
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
        public static bool UpdateInternalSellinvoiceById(
            string idInternalSellinvoice,
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
                string[] internalSell = new string[] {
                    idInternalSellinvoice,
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
                if (DataManagement.VerifyFields(internalSell))
                {
                    InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idInternalSellinvoice),
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
                    return InternalSellinvoiceConnection.UpdateInternalSellinvoice(internalSellinvoiceModel);
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
        /// <param name="idInternalSellinvoice"></param>
        /// <returns></returns>
        public static bool DeleteInternalSellinvoiceById(string idInternalSellinvoice)
        {
            try
            {
                string[] internalSell = new string[] { idInternalSellinvoice };
                if (DataManagement.VerifyFields(internalSell))
                {
                    InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idInternalSellinvoice)
                    };
                    return InternalSellinvoiceConnection.DeleteInternalSellinvoice(internalSellinvoiceModel);
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
        /// <param name="idInternalSellinvoice"></param>
        /// <returns></returns>
        public static InternalSellinvoiceModel SelectInternalSellinvoiceById(string idInternalSellinvoice)
        {
            try
            {
                string[] internalSell = new string[] { idInternalSellinvoice };
                InternalSellinvoiceModel internalSellinvoiceModel = new InternalSellinvoiceModel()
                {
                    IdSellinvoice = int.Parse(idInternalSellinvoice)
                };
                if (DataManagement.VerifyFields(internalSell))
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
                //Log4Net
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<InternalSellinvoiceModel> SelectAllInternalSellinvoice()
        {
            try
            {
                return InternalSellinvoiceConnection.SelectAllInternalSellinvoice();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
