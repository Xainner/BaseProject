using DataBaseLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class UserConnection
    {
        public static UserModel SelectUser(UserModel user)
        {
            try
            {
                //user = DBUser.SelectUser(user);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<UserModel> SelectAllUser()
        {
            try
            {
                return DBUser.SelectUserAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertUser(UserModel user)
        {
            try
            {
                DBUser.InsertUser(user);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateUser(UserModel user)
        {
            try
            {
                DBUser.UpdateUser(user);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteUser(UserModel user)
        {
            try
            {
                DBUser.DeleteUser(user);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
