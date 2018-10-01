using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.LogicManagement
{
    public class InputExitInvoiceManagement
    {

        public static bool InsertInputInvoice(string idEmployee, string provider)
        {
            try
            {
                string[] inputInvoice = new string[] { idEmployee, provider };
                if (ValidateData.VerifyFields(inputInvoice))
                {
                    InputExitDetaillsModel inputInvoiceModel = new InputExitDetaillsModel()
                    {
                        idEmployee = int.Parse(idEmployee),
                        ProviderBusiness = int.Parse(provider)
                    };
                    return DBInputExitInvoice.InsertInputInvoice(inputInvoiceModel);
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

        public static bool InsertExitInvoice(string idEmployee, string destiny)
        {
            try
            {
                string[] inputInvoice = new string[] { idEmployee, destiny };
                if (ValidateData.VerifyFields(inputInvoice))
                {
                    InputExitDetaillsModel inputInvoiceModel = new InputExitDetaillsModel()
                    {
                        idEmployee = int.Parse(idEmployee),
                        DestinyBusiness = int.Parse(destiny)
                    }; ;
                    return DBInputExitInvoice.InsertExitInvoice(inputInvoiceModel);
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

        public static List<InputExitDetaillsModel> SelectAllInputInvoice(string idInputInvoice)
        {
            try
            {
                //return DBInputExitInvoice.SelectAllInputInvoice();
                return null;
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        public static List<InputExitDetaillsModel> SelectAllExitInvoice(string idInputInvoice)
        {
            try
            {
                //return DBInputExitInvoice.SelectAllInputInvoice();
                return null;
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        public static InputExitDetaillsModel SelectInputExitInvoiceByIdNum(string idNumFact)
        {
            try
            {
                string[] inputExitInvoice = new string[] { idNumFact };
                if (ValidateData.VerifyFields(inputExitInvoice))
                {
                    InputExitDetaillsModel inputInvoiceModel = new InputExitDetaillsModel()
                    {
                        IdNumInvoice = int.Parse(idNumFact)
                    };
                    return DBInputExitInvoice.SelectInputExitInvoiceByIdNum(inputInvoiceModel);
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
    }
}
