using ModelLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.DataManagement
{
    public class ClientConnection
    {
        public static ClientModel SelectClient(ClientModel client)
        {
            try
            {
                //client = DBClient.SelectClient(client);
                return client;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ClientModel> SelectAllClient()
        {
            try
            {
                return DBClient.SelectClientAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertClient(ClientModel client)
        {
            try
            {
                DBClient.InsertClient(client);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateClient(ClientModel client)
        {
            try
            {
                DBClient.UpdateClient(client);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool DeleteClient(ClientModel client)
        {
            try
            {
                DBClient.DeleteClient(client);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }        

    }
}
