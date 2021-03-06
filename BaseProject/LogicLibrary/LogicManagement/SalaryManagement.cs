﻿
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
    public class SalaryManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salaryAmount"></param>
        /// <param name="registrationDate"></param>
        /// <returns></returns>
        public static bool InsertSalary(string salaryAmount)
        {
            try
            {
                string[] salary = new string[] { salaryAmount };
                if (ValidateData.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        SalaryAmount = decimal.Parse(salaryAmount),
                    };
                    return DBSalary.InsertSalary(salaryModel);
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
        public static bool UpdateSalaryById(string idSalary, string salaryAmount)
        {
            try
            {
                string[] salary = new string[] { idSalary, salaryAmount };
                if (ValidateData.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        IdSalary = int.Parse(idSalary),
                        SalaryAmount = decimal.Parse(salaryAmount)
                    };
                    return DBSalary.UpdateSalary(salaryModel);
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
                if (ValidateData.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        IdSalary = int.Parse(idSalary)
                    };
                    return DBSalary.DeleteSalary(salaryModel);
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
        public static List<SalaryModel> SelectSalaryById(string idSalary)
        {
            try
            {
                string[] salary = new string[] { idSalary };
                if (ValidateData.VerifyFields(salary))
                {
                    SalaryModel salaryModel = new SalaryModel()
                    {
                        IdSalary = int.Parse(idSalary)
                    };
                    return DBSalary.SelectidSalary(salaryModel);
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
                if (ValidateData.VerifyFields(salary))
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
                return DBSalary.SelectSalaryAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
