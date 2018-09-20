using BusinessLibrary.DataManagement;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ClientManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        /// <param name="idType"></param>
        /// <param name="email"></param>
        /// <param name="bornDate"></param>
        /// <returns></returns>
        public static bool InsertClient(string name, string lastName, string id, string idType, string email, string bornDate)
        {
            try
            {
                string[] client = new string[] { name, lastName, id, idType, email, bornDate };
                if (DataManagement.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        Name = name,
                        Lastname = lastName,
                        Identification = id,
                        IdentificationType = idType,
                        Email = email,
                        BornDate = bornDate
                    };
                    return ClientConnection.InsertClient(clientModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        /// <param name="idType"></param>
        /// <param name="email"></param>
        /// <param name="bornDate"></param>
        /// <returns></returns>
        public static bool UpdateClientById(string idClient, string name, string lastName, string id, string idType, string email, string bornDate)
        {
            try
            {
                string[] client = new string[] { idClient, name, lastName, id, idType, email, bornDate };
                if (DataManagement.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        IdClient = Int32.Parse(idClient),
                        Name = name,
                        Lastname = lastName,
                        Identification = id,
                        IdentificationType = idType,
                        Email = email,
                        BornDate = bornDate
                    };
                    return ClientConnection.UpdateClient(clientModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns></returns>
        public static bool DeleteClientById(string idClient)
        {
            try
            {
                string[] client = new string[] { idClient };
                if (DataManagement.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        IdClient = Int32.Parse(idClient)
                    };
                    return ClientConnection.DeleteClient(clientModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns></returns>
        public static ClientModel SelectClientById(string idClient)
        {
            try
            {
                string[] client = new string[] { idClient };
                if (DataManagement.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        IdClient = int.Parse(idClient)
                    };
                    return ClientConnection.SelectClient(clientModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ClientModel> SelectAllClients()
        {
            try
            {
                return ClientConnection.SelectAllClient();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
