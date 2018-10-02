using BusinessLibrary.Models;
using DataBaseLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class DetailExternalSellInvoiceManagement
    {

        public static bool InsertExternalSellinvoice(
             int IdClient,
             int IdEmployee,
             int IdBusiness,
             string CurrencyType,
             decimal IviAmount,
             decimal CashDeposit,
             decimal CreditDeposit,
             decimal TotalDiscount,
             decimal SubTotal,
             decimal Total
        )
        {
            try
            {
                string[] externalSellinvoice = new string[] {
                     CurrencyType,
                };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    DetailExternalSellinvoiceModel externalSellinvoiceModel = new DetailExternalSellinvoiceModel()
                    {
                        IdClient = IdClient,
                        IdEmployee = IdEmployee,
                        IdBusiness = IdBusiness,
                        CurrencyType = CurrencyType,
                        IviAmount = IviAmount,
                        CashDeposit = CashDeposit,
                        CreditDeposit = CreditDeposit,
                        TotalDiscount = TotalDiscount,
                        SubTotal = SubTotal,
                        Total = Total
                    };
                    return DBDetailExternalInvoiceSell.InsertExternalInvoice(externalSellinvoiceModel);
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


        public static bool updateExternalSellinvoice(
             string NumberInvoice,
             DateTime ActualDate,
             int IdClient,
             int IdEmployee,
             int IdBusiness,
             string CurrencyType,
             string IviAmount,
             string CashDeposit,
             string CreditDeposit,
             decimal TotalDiscount,
             decimal SubTotal,
             decimal Total
        )
        {
            try
            {
                string[] externalSellinvoice = new string[] {
                     NumberInvoice,
                     CurrencyType,
                     IviAmount,
                     CashDeposit,
                     CreditDeposit
                };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    DetailExternalSellinvoiceModel externalSellinvoiceModel = new DetailExternalSellinvoiceModel()
                    {
                        NumberInvoice = int.Parse(NumberInvoice),
                        ActualDate = ActualDate,
                        IdClient = IdClient,
                        IdEmployee = IdEmployee,
                        IdBusiness = IdBusiness,
                        CurrencyType = CurrencyType,
                        IviAmount = decimal.Parse(IviAmount),
                        CashDeposit = decimal.Parse(CashDeposit),
                        CreditDeposit = decimal.Parse(CreditDeposit),
                        TotalDiscount = TotalDiscount,
                        SubTotal = SubTotal,
                        Total = Total
                    };
                    return DBDetailExternalInvoiceSell.UpdateExternalInvoice(externalSellinvoiceModel);
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
        /// <returns></returns>
        public static bool DeleteExternalSellinvoiceById(string idExternalSellinvoice)
        {
            try
            {
                string[] externalSellinvoice = new string[] { idExternalSellinvoice };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    DetailExternalSellinvoiceModel internalSellinvoiceModel = new DetailExternalSellinvoiceModel()
                    {
                        NumberInvoice = int.Parse(idExternalSellinvoice)
                    };
                    return DBDetailExternalInvoiceSell.DeleteExternalSellInvoice(internalSellinvoiceModel);
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
        public static DetailExternalSellinvoiceModel SelectExternalSellinvoiceById(string idExternalSellinvoice)
        {
            try
            {
                string[] externalSellinvoice = new string[] { idExternalSellinvoice };
                if (ValidateData.VerifyFields(externalSellinvoice))
                {
                    DetailExternalSellinvoiceModel externalSellinvoiceModel = new DetailExternalSellinvoiceModel()
                    {
                        NumberInvoice = int.Parse(idExternalSellinvoice)
                    };
                    return DBDetailExternalInvoiceSell.SelectExternalInvoiceById(externalSellinvoiceModel);
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
        public static List<DetailExternalSellinvoiceModel> SelectAllExternalSellinvoice()
        {
            try
            {
                return DBDetailExternalInvoiceSell.SelectAllExternalInvoices();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
