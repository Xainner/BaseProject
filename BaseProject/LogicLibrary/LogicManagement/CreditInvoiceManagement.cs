using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class CreditInvoiceManagement
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
        /// <param name="range"></param>
        /// <param name="interests"></param>
        /// <param name="amountOfDues"></param>
        /// <param name="cashDeposit"></param>
        /// <param name="cardDeposit"></param>
        /// <param name="inflation"></param>
        /// <returns></returns>
        public static bool InsertCreditInvoice(
            string numInvoice,
            string date,
            string idClient,
            string idEmployee,
            string idBusiness,
            string idUser,
            //List<ProductModel> products,
            string coinType,
            string paymentType,
            string iviAmount,
            string currencyType,
            string paymentCash,
            string totalDiscount,
            string subTotal,
            string total,
            string range,
            string interests,
            string amountOfDues,
            string cashDeposit,
            string cardDeposit,
            string inflation
        )
        {
            try
            {
                string[] creditInvoice = new string[] {
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
                    total,
                    range,
                    interests,
                    amountOfDues,
                    cashDeposit,
                    cardDeposit,
                    inflation
                };
                if (ValidateData.VerifyFields(creditInvoice))
                {
                    CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                    {
                        AmountOfDues = decimal.Parse(amountOfDues),
                        CardDeposit = decimal.Parse(cardDeposit),
                        CashDeposit = decimal.Parse(cashDeposit),
                        CoinType = coinType,
                        CurrencyType = currencyType,
                        Date = date,
                        IdBusiness = int.Parse(idBusiness),
                        IdClient = int.Parse(idClient),
                        IdEmployee = int.Parse(idEmployee),
                        IdUser = int.Parse(idUser),
                        Inflation = decimal.Parse(inflation),
                        Interests = interests,
                        IviAmount = iviAmount,
                        NumInvoice = numInvoice,
                        PaymentCash = decimal.Parse(paymentCash),
                        PaymentType = paymentType,
                        //Products = products,
                        Range = range,
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
        /// <param name="idSellinvoice"></param>
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
        /// <param name="range"></param>
        /// <param name="interests"></param>
        /// <param name="amountOfDues"></param>
        /// <param name="cashDeposit"></param>
        /// <param name="cardDeposit"></param>
        /// <param name="inflation"></param>
        /// <returns></returns>
        public static bool UpdateCreditInvoiceById(
            string idSellinvoice,
            string numInvoice,
            string date,
            string idClient,
            string idEmployee,
            string idBusiness,
            string idUser,
            //List<ProductModel> products,
            string coinType,
            string paymentType,
            string iviAmount,
            string currencyType,
            string paymentCash,
            string totalDiscount,
            string subTotal,
            string total,
            string range,
            string interests,
            string amountOfDues,
            string cashDeposit,
            string cardDeposit,
            string inflation
        )
        {
            try
            {
                string[] creditInvoice = new string[] {
                    idSellinvoice,
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
                    total,
                    range,
                    interests,
                    amountOfDues,
                    cashDeposit,
                    cardDeposit,
                    inflation
                };

                if (ValidateData.VerifyFields(creditInvoice))
                {
                    CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idSellinvoice),
                        AmountOfDues = decimal.Parse(amountOfDues),
                        CardDeposit = decimal.Parse(cardDeposit),
                        CashDeposit = decimal.Parse(cashDeposit),
                        CoinType = coinType,
                        CurrencyType = currencyType,
                        Date = date,
                        IdBusiness = int.Parse(idBusiness),
                        IdClient = int.Parse(idClient),
                        IdEmployee = int.Parse(idEmployee),
                        IdUser = int.Parse(idUser),
                        Inflation = decimal.Parse(inflation),
                        Interests = interests,
                        IviAmount = iviAmount,
                        NumInvoice = numInvoice,
                        PaymentCash = decimal.Parse(paymentCash),
                        PaymentType = paymentType,
                        //Products = products,
                        Range = range,
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
        /// <param name="idSellinvoice"></param>
        /// <returns></returns>
        public static bool DeleteCreditInvoiceById(string idSellinvoice)
        {
            try
            {
                string[] creditInvoice = new string[] { idSellinvoice };
                if (ValidateData.VerifyFields(creditInvoice))
                {
                    CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idSellinvoice)
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
        /// <param name="idSellinvoice"></param>
        /// <returns></returns>
        public static CreditInvoiceModel SelecCreditInvoiceById(string idSellinvoice)
        {
            try
            {
                string[] creditInvoice = new string[] { idSellinvoice };
                if (ValidateData.VerifyFields(creditInvoice))
                {
                    CreditInvoiceModel creditInvoiceModel = new CreditInvoiceModel()
                    {
                        IdSellinvoice = int.Parse(idSellinvoice)
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
        public static List<CreditInvoiceModel> SelectAllCreditInvoices()
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
