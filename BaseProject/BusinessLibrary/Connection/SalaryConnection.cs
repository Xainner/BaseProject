using BusinessLibrary.Models;
//using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class SalaryConnection
    {
        public static SalaryModel SelectSalary(SalaryModel salary)
        {
            try
            {
                //salary = DBSalary.SelectSalary(salary);
                return salary;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SalaryModel> SelectAllSalary()
        {
            try
            {
                //return DBSalary.SelectSalaryAll();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertSalary(SalaryModel salary)
        {
            try
            {
                //DBSalary.InsertSalary(salary);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateSalary(SalaryModel salary)
        {
            try
            {
                //DBSalary.UpdateSalary(salary);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteSalary(SalaryModel salary)
        {
            try
            {
                //DBSalary.DeleteSalary(salary);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
