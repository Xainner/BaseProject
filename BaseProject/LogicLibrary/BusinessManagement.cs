using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BusinessManagement
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

        public static bool InsertUser(string fantasyName, string societyName, string legalCertification, string telephone, string mainAddress, string generalAddress, string email, string webPage, byte[] logo)
        {
            try
            {
                //TEMP
                string[] business = new string[] { fantasyName, societyName, legalCertification, telephone, mainAddress, generalAddress, email, webPage };
                //TEMP
                if (VerifyFields(business))
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

        public static bool UpdateBusinessById(string idBusiness, string fantasyName, string societyName, string legalCertification, string telephone, string mainAddress, string generalAddress, string email, string webPage, byte[] logo)
        {
            try
            {
                //TEMP
                string[] business = new string[] { idBusiness, fantasyName, societyName, legalCertification, telephone, mainAddress, generalAddress, email, webPage };
                //TEMP
                if (VerifyFields(business))
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

        public static bool DeleteBusinessById(string idBusiness)
        {
            try
            {
                //TEMP
                string[] business = new string[] { idBusiness };
                //TEMP
                if (VerifyFields(business))
                {
                    //BS.DeleteUserById(business);
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

        public static bool SelectBusinessById(string idBusiness)
        {
            try
            {
                //TEMP
                string[] business = new string[] { idBusiness };
                //TEMP
                if (VerifyFields(business))
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
