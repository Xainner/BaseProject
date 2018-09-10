using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    class SalaryConection
    {
        public static List<SalaryModel> SelectSalary(SalaryModel salary)
        {
            try
            {
                //ClaseBD.SelectSalary(salary);
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
