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
                //TEMP
                if (VerifyFields(user))
                {
                    //BS.InsertUser(user);
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
                //TEMP
                if (VerifyFields(user))
                {
                    //BS.UpdateUserPassword(user);
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

        public static bool DeleteUserById(string idUser)
        {
            try
            {
                //TEMP
                string[] user = new string[] { idUser };
                //TEMP
                if (VerifyFields(user))
                {
                    //BS.DeleteUserById(user);
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

        public static bool SelectUserById(string idUser)
        {
            try
            {
                //TEMP
                string[] user = new string[] { idUser };
                //TEMP
                if (VerifyFields(user))
                {
                    //BS.SelectUserById(user);
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

        //public static List<UsertModel> SelectAllUsers()
        //{
        //    try
        //    {
        //        return BS.SelectAllUsers();
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        Log4Net
        //    }
        //}
    }
}
