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
    public class DBClient
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

        // Client

        /// <summary>
        /// Show all clients in the table client
        /// </summary>
        /// <returns>output</returns>
        public static List<ClientModel> SelectClientAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM client");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific client by idClient
        /// </summary>
        /// <param name="Client"></param>
        /// <returns>output</returns>
        public static ClientModel SelectidClient(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<ClientModel>("SELECT * FROM client WHERE idClient = @idClient", Client);
                return output;
            }
        }

        /// <summary>
        /// Show a specific client by Name or lastName
        /// </summary>
        /// <param name="Client"></param>
        /// <returns>output</returns>
        public static List<ClientModel> SelectNameOrLastName(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                string name = "%" + Client.Name + "%";
                string lastname = "%"+ Client.Lastname + "%";
                Client.Name = name;
                Client.Lastname = lastname;
                var output = cnn.Query<ClientModel>(
                    "SELECT * FROM client WHERE (Name Like @Name) or " +
                    "(lastName Like @lastName)", Client);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a client from client
        /// </summary>
        /// <param name="Client"></param>
        public static bool InsertClient(ClientModel Client)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO client" +
                        "(Name, lastName, identificationType, Identification, Email, " +
                        "bornDate) VALUES" +
                        "(@Name, @lastName, @identificationType, @Identification, @Email, " +
                        "@bornDate)", Client);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete a client from client
        /// </summary>
        /// <param name="Client"></param>
        public static bool DeleteClient(ClientModel Client)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM client WHERE idClient = @idClient", Client);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Update a client from client
        /// </summary>
        /// <param name="Client"></param>
        public static bool UpdateClient(ClientModel Client)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE client " +
                        "SET Name = @Name, lastName = @lastName, " +
                        "identificationType = @identificationType, " +
                        "Identification = @Identification, Email = @Email, " +
                        "bornDate = @bornDate " +
                        "WHERE idClient = @idClient", Client);
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
