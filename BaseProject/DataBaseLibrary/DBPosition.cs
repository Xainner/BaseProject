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
        public static bool InsertPosition(PositionModel Position)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO position (positionName, idSalary) VALUES" +
                        "(@positionName, @idSalary)", Position);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete a position from position
        /// </summary>
        /// <param name="Position"></param>
        public static bool DeletePosition(PositionModel Position)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM position WHERE idPosition = @idPosition", Position);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Update a position from position
        /// </summary>
        /// <param name="Position"></param>
        public static bool UpdatePosition(PositionModel Position)
        {
            try
            {
                using (IDbConnection cnn = new MySqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE position " +
                        "SET positionName = @positionName, idSalary = @idSalary " +
                        "WHERE idPosition = @idPosition", Position);
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
