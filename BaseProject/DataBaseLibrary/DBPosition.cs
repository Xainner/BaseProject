using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

using ModelLibrary.Models;
using System.Configuration;

namespace DataBaseLibrary
{
    public class DBPosition
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

        // Position

        /// <summary>
        /// Show all positions in the table position
        /// </summary>
        /// <returns>output</returns>
        public static List<PositionModel> SelectPositionAll()
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PositionModel>("SELECT * FROM position");
                return output.ToList();
            }
        }

        /// <summary>
        /// Show a specific position by idPosition
        /// </summary>
        /// <param name="Position"></param>
        /// <returns>output</returns>
        public static List<PositionModel> SelectidPosition(PositionModel Position)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PositionModel>("SELECT * FROM position WHERE idPosition = @idPosition", Position);
                return output.ToList();
            }
        }

        /// <summary>
        /// Insert a position from position
        /// </summary>
        /// <param name="Position"></param>
        public static void InsertPosition(PositionModel Position)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO position" +
                    "(positionName, idSalary) VALUES" +
                    "(@positionName, @idSalary)", Position);
            }
        }

        /// <summary>
        /// Delete a position from position
        /// </summary>
        /// <param name="Position"></param>
        public static void DeletePosition(PositionModel Position)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM position WHERE idPosition = @idPosition", Position);
            }
        }

        /// <summary>
        /// Update a position from position
        /// </summary>
        /// <param name="Position"></param>
        public static void UpdatePosition(PositionModel Position)
        {
            using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE position " +
                    "SET positionName = @positionName, idSalary = @idSalary " +
                    "WHERE idPosition = @idPosition", Position);
            }
        }
    }
}
