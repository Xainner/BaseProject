using BusinessLibrary.Conection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class UserManagement
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

        public static bool InsertUser(string userName, string password, string[] idRole, string name, string lastName)
        {
            try
            {
                //TEMP
                string[] user = new string[] { userName, password, name, lastName };
                UserModel userModel = new UserModel()
                {
                    UserName = userName,
                    Password = password,
                    IdRole = 0
                };
                //TEMP
                if (VerifyFields(user))
                {
                    return UserConnection.InsertUser(userModel);
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

        //Para qué?
        public static bool UpdateUserById(string idUser, string userName, string password, string[] idRole, string name, string lastName)
        {
            try
            {
                //TEMP
                string[] user = new string[] { idUser, userName, name, lastName };
                //TEMP
                if (VerifyFields(user))
                {
                    //BS.UpdateUserById(user);
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

        public static bool UpdateUserPassword(string idUser, string password)
        {
            try
            {
                //TEMP
                string[] user = new string[] { idUser, password };
                UserModel userModel = new UserModel()
                {
                    IdUser = int.Parse(idUser)
                    
                };
                if (VerifyFields(user))
                {
                    return UserConnection.UpdateUser(userModel);
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

        public static bool DeleteUserById(string idUser)
        {
            try
            {
                //TEMP
                string[] user = new string[] { idUser };
                UserModel userModel = new UserModel()
                {
                    IdUser = int.Parse(idUser)
                };
                if (VerifyFields(user))
                {
                    return UserConnection.DeleteUser(userModel);

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

        public static UserModel SelectUserById(string idUser)
        {
            try
            {
                //TEMP
                string[] user = new string[] { idUser };
                UserModel userModel = new UserModel()
                {
                    IdUser = int.Parse(idUser)
                };
                if (VerifyFields(user))
                {
                    return UserConnection.SelectUser(userModel);
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

        public static List<UserModel> SelectAllUsers()
        {
            try
            {
                return UserConnection.SelectAllUser();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
