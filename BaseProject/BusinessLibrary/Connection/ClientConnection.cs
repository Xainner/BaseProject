using BusinessLibrary.Models;
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
                //client = BDClient.SelectClient(client);
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
                //BDClient.SelectAllClient();
                return null;
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
                //BDClient.InsertClient(client);
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
                //BDClient.UpdateClient(client);
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
                //BDClient.DeleteClient(client);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }        

    }
}
