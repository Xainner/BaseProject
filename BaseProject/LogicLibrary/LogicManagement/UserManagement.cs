using BusinessLibrary.Conection;

using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class UserManagement
    {

        //public static bool InsertUser(string userName, string password, string idEmployee)
        //{
        //    try
        //    {
        //        string[] user = new string[] { userName, password, idEmployee };
        //        UserModel userModel = new UserModel()
        //        {
        //            UserName = userName,
        //            Password = password,
        //            IdRole = 0
        //        };
        //        if (ValidateData.VerifyFields(user))
        //        {
        //            return UserConnection.InsertUser(userModel);
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log4Net
        //        return false;
        //    }
        //}

        //Para qué?
        //public static bool UpdateUserById(string idUser, string userName, string password, string[] idRole, string name, string lastName)
        //{
        //    try
        //    {
        //        string[] user = new string[] { idUser, userName, name, lastName };

        //        if (ValidateData.VerifyFields(user))
        //        {
        //            UserConnection.UpdateUser();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log4Net
        //        return false;
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool UpdateUserPassword(string idUser, string password)
        {
            try
            {
                string[] user = new string[] { idUser, password };
                if (ValidateData.VerifyFields(user))
                {
                    UserModel userModel = new UserModel()
                    {
                        IdUser = int.Parse(idUser),
                        Password = PasswordManagement.HashPassword(password)
                    };
                    return UserConnection.UpdateUser(userModel);
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
        /// <param name="idUser"></param>
        /// <returns></returns>
        public static bool DeleteUserById(string idUser)
        {
            try
            {
                string[] user = new string[] { idUser };
                if (ValidateData.VerifyFields(user))
                {
                    UserModel userModel = new UserModel()
                    {
                        IdUser = int.Parse(idUser)
                    };
                    return UserConnection.DeleteUser(userModel);
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
        /// <param name="idUser"></param>
        /// <returns></returns>
        public static UserModel SelectUserById(string idUser)
        {
            try
            {
                string[] user = new string[] { idUser };
                if (ValidateData.VerifyFields(user))
                {
                    UserModel userModel = new UserModel()
                    {
                        IdUser = int.Parse(idUser)
                    };
                    return UserConnection.SelectUser(userModel);
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
        /// <param name="userName"></param>
        /// <returns></returns>
        public static UserModel SelectUserByUserName(string userName)
        {
            try
            {
                string[] user = new string[] { userName };
                if (ValidateData.VerifyFields(user))
                {
                    UserModel userModel = new UserModel()
                    {
                        UserName = userName
                    };
                    return UserConnection.SelectUser(userModel);
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
