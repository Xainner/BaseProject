using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

using BusinessLibrary.Models;
using System.Configuration;

namespace DataBaseLibrary
{
    public class DBEmployee
    {
        /// <summary>
        /// Make the connection with the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ConfigurationManager</returns>
        private static String LoadConnectionString(String id = "User")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // Employee

        /// <summary>
        /// Show all employee in the table employee
        /// </summary>
        /// <returns>output</returns>
        public static List<EmployeeModel> SelectEmployeeAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EmployeeModel>("SELECT * FROM employee");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific employee by idEmployee
        /// </summary>
        /// <param name="Employee"></param>
        /// <returns>output</returns>
        public static List<EmployeeModel> SelectidEmployee(EmployeeModel Employee)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EmployeeModel>("SELECT * FROM employee WHERE idEmployee = @idEmployee", Employee);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific employee by Identification
        /// </summary>
        /// <param name="Employee"></param>
        /// <returns>output</returns>
        public static List<EmployeeModel> SelectIdentification(EmployeeModel Employee)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EmployeeModel>("SELECT * FROM employee WHERE Identification = @Identification", Employee);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific employee by Name or lastName
        /// </summary>
        /// <param name="Employee"></param>
        /// <returns>output</returns>
        public static List<EmployeeModel> SelectNameOrLastName(EmployeeModel Employee)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EmployeeModel>(
                    "SELECT * FROM employee WHERE (Name = @Name" + "%" + ") or " +
                    "(lastName = @lastName " + "%" + ")", Employee);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a employee from employee
        /// </summary>
        /// <param name="Employee"></param>
        public static void InsertEmployee(EmployeeModel Employee)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO employee" +
                    "(Name, lastName, identificationType, Identification, Residence, " +
                    "bornDate, civilState, Childs, Telephone, Cellphone, enterStore, Nationality, " +
                    "workingState, enterDate, endDate, Observation, Image, nameEmergency, " +
                    "cellphoneEmergency, idPosition) VALUES" +
                    "(@Name, @lastName, @identificationType, @Identification, @Residence, " +
                    "@bornDate, @civilState, @Childs, @Telephone, @Cellphone, @enterStore, @Nationality, " +
                    "@workingState, @enterDate, @endDate, @Observation, @Image, @nameEmergency, " +
                    "@cellphoneEmergency, @idPosition)", Employee);
            }
        }

        /// <summary>
        /// Delete a employee from employee
        /// </summary>
        /// <param name="Employee"></param>
        public static void DeleteEmployee(EmployeeModel Employee)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM employee WHERE idEmployee = @idEmployee", Employee);
            }
        }

        /// <summary>
        /// Update a employee from employee
        /// </summary>
        /// <param name="Employee"></param>
        public static void UpdateEmployee(EmployeeModel Employee)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE employee " +
                    "SET Name = @Name, lastName = @lastName, identificationType = @identificationType, " +
                    "Identification = @Identification, residence = @Residence, " +
                    "bornDate = @bornDate, civilState = @civilState, Childs = @Childs, Telephone = @Telephone, " +
                    "Cellphone = @Cellphone, enterStore = @enterStore, Nationality = @Nationality, " +
                    "workingState = @workingState, enterDate = @enterDate, endDate = @endDate, Observation = @Observation, " +
                    "Image = @Image, nameEmergency = @nameEmergency, cellphoneEmergency = @cellphoneEmergency, " +
                    "idPosition = @idPosition WHERE idEmployee = @idEmployee", Employee);
            }
        }
    }
}
