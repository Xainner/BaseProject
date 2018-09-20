using BusinessLibrary.Models;
using DataBaseLibrary;
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
                //employee = DBEmployee.SelectEmployee(employee);
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
                return DBEmployee.SelectEmployeeAll();
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
                DBEmployee.InsertEmployee(employee);
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
                DBEmployee.UpdateEmployee(employee);
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
                DBEmployee.DeleteEmployee(employee);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
