using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.LogicManagement
{
    public class DetailApartManagement
    {

        public static bool InsertDetailApart(string idEmployee, string idClient, string idBusiness, string endDate, string discount, string subtotal,
            string total, string paymentType, string currentPayment, string ivi, string residue)
        {
            try
            {
                string[] inputInvoice = new string[] { idEmployee, idClient, idBusiness, endDate, discount, subtotal, total,
                    paymentType, currentPayment, ivi, residue };
                if (ValidateData.VerifyFields(inputInvoice))
                {
                    DetailApartModel detailApart = new DetailApartModel()
                    {
                        idEmployee = int.Parse(idEmployee),
                        IdClient = int.Parse(idClient),
                        IdBusiness = int.Parse(idBusiness),
                        currentDate = DateTime.Parse(endDate),
                        discount = decimal.Parse(discount),
                        SubTotal = decimal.Parse(subtotal),
                        Total = decimal.Parse(total),
                        PaymentType = paymentType,
                        CurrentPayment = decimal.Parse(currentPayment),
                        Ivi = decimal.Parse(ivi),
                        Residue = decimal.Parse(residue)
                    };
                    return DBDetailsApart.InsertDetailApart(detailApart);
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

        public static DetailApartModel SelectDetailsApartID()
        {
            try
            {
                return DBDetailsApart.SelectDetailsApartID();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

    }
}
