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
        public static bool VerifyFields(string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    return false;
                }
            }
            return false;
        }

        public static bool InsertClient(string name, string lastName, string id, string idType, string email, string bornDate)
        {
            try
            {
                //TEMP
                string[] client = new string[] { name, lastName, id, idType, email, bornDate };

                ClientModel clientModel = new ClientModel()
                {
                    Name = name,
                    Lastname = lastName,
                    Identification = id,
                    IdentificationType = idType,
                    Email = email,
                    BornDate = bornDate
                };

                if (VerifyFields(client))
                {
                    ClientConnection.InsertClient(clientModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool UpdateClientById(string idClient, string name, string lastName, string id, string idType, string email, string bornDate)
        {
            try
            {
                //TEMP
                string[] client = new string[] { idClient, name, lastName, id, idType, email, bornDate };
                //TEMP
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

                if (VerifyFields(client))
                {
                    ClientConnection.UpdateClient(clientModel);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static bool DeleteClientById(string idClient)
        {
            try
            {
                //TEMP
                string[] client = new string[] { idClient };
                //TEMP
                ClientModel clientModel = new ClientModel()
                {
                    IdClient = Int32.Parse(idClient)
                };

                if (VerifyFields(client))
                {
                    return ClientConnection.DeleteClient(clientModel);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //Log4Net
            }
        }

        public static ClientModel SelectClientById(string idClient)
        {
            try
            {
                //TEMP
                string[] client = new string[] { idClient };
                ClientModel clientModel = new ClientModel()
                {
                    IdClient = int.Parse(idClient)
                };
                if (VerifyFields(client))
                {
                    return ClientConnection.SelectClient(clientModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }

        public static List<ClientModel> SelectAllClients()
        {
            try
            {
                return ClientConnection.SelectAllClient();
            }
            catch (Exception ex)
            {
                return null;
                //Log4Net
            }
        }
    }
}
