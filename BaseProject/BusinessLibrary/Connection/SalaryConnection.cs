using BusinessLibrary.Models;
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
                //salary = ClaseBD.SelectSalary(salary);
                return salary;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SalaryModel> SelectAllSalary(SalaryModel salary)
        {
            try
            {
                //ClaseBD.SelectAllSalary(salary);
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
                //ClaseBD.InsertSalary(salary);
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
                //ClaseBD.UpdateSalary(salary);
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
                //ClaseBD.DeleteSalary(salary);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
