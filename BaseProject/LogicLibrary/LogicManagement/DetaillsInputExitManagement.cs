using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.LogicManagement
{
    public class DetaillsInputExitManagement
    {
        public static bool InsertDetailsInputExit(string idEmployee, string destiny, string provider)
        {
            try
            {
                string[] inputInvoice = new string[] { idEmployee, destiny, provider };
                if (ValidateData.VerifyFields(inputInvoice))
                {
                    InputExitDetaillsModel inputInvoiceModel = new InputExitDetaillsModel()
                    {
                        idEmployee = int.Parse(idEmployee),
                        destinyBusiness = int.Parse(destiny),
                        ProviderBusiness = int.Parse(provider)
                    };
                    return DBDetailsInputExit.InsertInputExitInvoice(inputInvoiceModel);
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

        public static List<InputExitDetaillsModel> SelectAllDetaillsInputExit(string idInputInvoice)
        {
            try
            {
                //return DBDetailsInputExit.SelectAllInputInvoice();
                return null;
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        public static InputExitDetaillsModel SelectDetailsInputExitID()
        {
            try
            {
                return DBDetailsInputExit.SelectDetailsInputExitID();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

    }
}
