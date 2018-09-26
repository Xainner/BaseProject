using BusinessLibrary.Models;
using DataBaseLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;

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
                string[] client = new string[] { name, lastName, id, idType };
                if (ValidateData.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        Name = name,
                        Lastname = lastName,
                        Identification = id,
                        IdentificationType = idType,
                        Email = email,
                        BornDate = DateTime.Parse(bornDate)
                    };
                    return DBClient.InsertClient(clientModel);
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
                if (ValidateData.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        IdClient = Int32.Parse(idClient),
                        Name = name,
                        Lastname = lastName,
                        Identification = id,
                        IdentificationType = idType,
                        Email = email,
                        BornDate = DateTime.Parse(bornDate)
                    };
                    return DBClient.UpdateClient(clientModel);
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
                if (ValidateData.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        IdClient = Int32.Parse(idClient)
                    };
                    return DBClient.DeleteClient(clientModel);
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
                if (ValidateData.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        IdClient = int.Parse(idClient)
                    };
                    //return ClientConnection.SelectClient(clientModel);}
                    return null;
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
        /// <param name="toSearch"></param>
        /// <returns></returns>
        public static List<ClientModel> SelectClientByNameOrLastName(string toSearch)
        {
            try
            {
                string[] client = new string[] { toSearch };
                if (ValidateData.VerifyFields(client))
                {
                    ClientModel clientModel = new ClientModel()
                    {
                        Name = toSearch,
                        Lastname = toSearch
                    };
                    return DBClient.SelectNameOrLastName(clientModel);
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
                return DBClient.SelectClientAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
