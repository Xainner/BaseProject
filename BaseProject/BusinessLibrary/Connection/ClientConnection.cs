﻿using BusinessLibrary.Models;
using log4net.Config;
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
                //client = ClaseBD.SelectClient(client);
                return client;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ClientModel> SelectAllClient(ClientModel client)
        {
            try
            {
                //ClaseBD.SelectAllClient(client);
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
                //ClaseBD.InsertClient(client);
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
                //ClaseBD.UpdateClient(client);
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
                //ClaseBD.DeleteClient(client);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }        

    }
}
