using BusinessLibrary.Models;
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
                //user = ClaseBD.SelectUser(user);
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
                //ClaseBD.SelectAllUser();
                return null;
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
                //ClaseBD.InsertUser(user);
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
                //ClaseBD.UpdateUser(user);
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
                //ClaseBD.DeleteUser(user);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
