using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;
using System.Configuration;
using BusinessLibrary.Models;

namespace DataBaseLibrary
{
    public class DBSalary
    {
        /// <summary>
        /// Make the connection with the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ConfigurationManager</returns>
        private static String LoadConnectionString(String id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // Salary

        /// <summary>
        /// Show all salaries in the table salary
        /// </summary>
        /// <returns>output</returns>
        public static List<SalaryModel> SelectSalaryAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SalaryModel>("SELECT * FROM salary");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific salary by idSalary
        /// </summary>
        /// <param name="Salary"></param>
        /// <returns>output</returns>
        public static List<SalaryModel> SelectidSalary(SalaryModel Salary)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SalaryModel>("SELECT * FROM salary WHERE idSalary = @idSalary", Salary);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show salaries from one date to the current
        /// </summary>
        /// <param name="Salary"></param>
        /// <returns>output</returns>
        public static List<SalaryModel> SelectByDate(SalaryModel Salary)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SalaryModel>(
                    "SELECT * FROM salary WHERE CURDATE() >= @registrationDate", Salary);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a salary from salary
        /// </summary>
        /// <param name="Salary"></param>
        public static bool InsertSalary(SalaryModel Salary)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO salary" +
                        "(salaryAmount) VALUES" +
                        "(@salaryAmount)", Salary);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete a salary from salary
        /// </summary>
        /// <param name="Salary"></param>
        public static bool DeleteSalary(SalaryModel Salary)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM salary WHERE idSalary = @idSalary", Salary);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Update a salary from salary
        /// </summary>
        /// <param name="Salary"></param>
        public static bool UpdateSalary(SalaryModel Salary)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE salary " +
                        "SET salaryAmount = @salaryAmount " +
                        "WHERE idSalary = @idSalary", Salary);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
