using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class EmployeeConnection
    {
        public static EmployeeModel SelectEmployee(EmployeeModel employee)
        {
            try
            {
                //employee = ClaseBD.SelectEmployee(employee);
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EmployeeModel> SelectAllEmployee()
        {
            try
            {
                //ClaseBD.SelectAllEmployee();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertEmployee(EmployeeModel employee)
        {
            try
            {
                //ClaseBD.InsertEmployee(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                //ClaseBD.UpdateEmployee(brand);
                //ClaseBD.UpdateEmployee(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteEmployee(EmployeeModel employee)
        {
            try
            {
                //ClaseBD.DeleteEmployee(brand);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
