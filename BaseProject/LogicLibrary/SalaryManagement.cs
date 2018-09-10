using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class SalaryManagement
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

        public static bool InsertSalary(string positionName, string registrationDate)
        {
            try
            {
                //TEMP
                string[] salary = new string[] { positionName, registrationDate };
                //TEMP
                if (VerifyFields(salary))
                {
                    //BS.InsertSalary(user);
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

        public static bool UpdateSalaryById(string idSalary, string positionName)
        {
            try
            {
                //TEMP
                string[] salary = new string[] { idSalary, positionName };
                //TEMP
                if (VerifyFields(salary))
                {
                    //METHOD
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

        public static bool DeleteSalaryById(string idSalary)
        {
            try
            {
                //TEMP
                string[] salary = new string[] { idSalary };
                //TEMP
                if (VerifyFields(salary))
                {
                    //METHOD
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

        public static bool SelectSalaryById(string idSalary)
        {
            try
            {
                //TEMP
                string[] salary = new string[] { idSalary };
                //TEMP
                if (VerifyFields(salary))
                {
                    //METHOD
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

        //public static SalaryModel SelectAllSalaries()
        //{
        //    try
        //    {
        //        //METHOD
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        Log4Net
        //    }
        //}
    }
}
