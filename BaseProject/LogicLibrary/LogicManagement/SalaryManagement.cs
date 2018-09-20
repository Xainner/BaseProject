using BusinessLibrary.Conection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class SalaryManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salaryAmount"></param>
        /// <param name="registrationDate"></param>
        /// <returns></returns>
        public static bool InsertSalary(string salaryAmount, string registrationDate)
        {
            try
            {
                string[] salary = new string[] { salaryAmount, registrationDate };
                if (DataManagement.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        RegistrationDate = registrationDate,
                        SalaryAmount = decimal.Parse(salaryAmount)
                    };
                    return SalaryConnection.InsertSalary(salaryModel);
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
        /// <param name="idSalary"></param>
        /// <param name="salaryAmount"></param>
        /// <param name="registrationDate"></param>
        /// <returns></returns>
        public static bool UpdateSalaryById(string idSalary, string salaryAmount, string registrationDate)
        {
            try
            {
                string[] salary = new string[] { idSalary, salaryAmount, registrationDate };
                if (DataManagement.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        IdSalary = int.Parse(idSalary),
                        RegistrationDate = registrationDate,
                        SalaryAmount = decimal.Parse(salaryAmount)
                    };
                    return SalaryConnection.InsertSalary(salaryModel);
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
        /// <param name="idSalary"></param>
        /// <returns></returns>
        public static bool DeleteSalaryById(string idSalary)
        {
            try
            {
                string[] salary = new string[] { idSalary };
                if (DataManagement.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        IdSalary = int.Parse(idSalary)
                    };
                    return SalaryConnection.InsertSalary(salaryModel);
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
        /// <param name="idSalary"></param>
        /// <returns></returns>
        public static SalaryModel SelectSalaryById(string idSalary)
        {
            try
            {
                string[] salary = new string[] { idSalary };
                if (DataManagement.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        IdSalary = int.Parse(idSalary)
                    };
                    return SalaryConnection.SelectSalary(salaryModel);
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
        /// <param name="registrationDate"></param>
        /// <returns></returns>
        public static SalaryModel SelectSalaryByRegistrationDate(string registrationDate)
        {
            try
            {
                string[] salary = new string[] { registrationDate };
                if (DataManagement.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        RegistrationDate = registrationDate
                    };
                    //return SalaryConnection.SelectSalaryByDate(salaryModel);
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
        public static List<SalaryModel> SelectAllSalaries()
        {
            try
            {
                return SalaryConnection.SelectAllSalary();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
