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
    public class DBClient
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

        // Client

        /// <summary>
        /// Show all clients in the table client
        /// </summary>
        /// <returns>output</returns>
        public List<ClientModel> SelectClientAll()
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
        public List<ClientModel> SelectidClient(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM client WHERE idClient = @idClient", Client);
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific client by Name or lastName
        /// </summary>
        /// <param name="Client"></param>
        /// <returns>output</returns>
        public List<ClientModel> SelectNameorLastName(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>(
                    "SELECT * FROM client WHERE (Name = @Name"+"%"+") or " +
                    "(lastName = @lastName "+"%"+")", Client);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a client from client
        /// </summary>
        /// <param name="Client"></param>
        public static void InsertClient(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO client" +
                    "(Name, lastName, identificationType, Identification, Email, " +
                    "bornDate, registrationDate) VALUES" +
                    "(@Name, @lastName, @identificationType, @Identification, @Email, " +
                    "@bornDate, @registrationDate)", Client);
            }
        }

        /// <summary>
        /// Delete a client from client
        /// </summary>
        /// <param name="Client"></param>
        public static void DeleteClient(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM client WHERE idClient = @idClient", Client);
            }
        }

        /// <summary>
        /// Update a client from client
        /// </summary>
        /// <param name="Client"></param>
        public static void UpdateBusiness(ClientModel Client)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE business " +
                    "SET Name = @Name, lastName = @lastName, " +
                    "identificationType = @identificationType, " +
                    "Identification = @Identification, Email = @Email, " +
                    "bornDate = @bornDate, registrationDate = @registrationDate " +
                    "WHERE idClient = @idClient", Client);
            }
        }
    }
}
