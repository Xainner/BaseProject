using BusinessLibrary.Conection;
using BusinessLibrary.Models;
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
                BusinessModel businessModel = new BusinessModel()
                {
                    FantasyName = fantasyName,
                    SocietyName = societyName,
                    LegalCertification = legalCertification,
                    Telephone = telephone,
                    MainAddress = mainAddress,
                    GeneralAddress = generalAddress,
                    Email = email,
                    WebPage = webPage
                };
                if (VerifyFields(business))
                {
                    BusinessConnection.InsertBusiness(businessModel);
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
                BusinessModel businessModel = new BusinessModel()
                {
                    IdBusiness = int.Parse(idBusiness)
                };
                if (VerifyFields(business))
                {
                    BusinessConnection.UpdateBusiness(businessModel);
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
                if (VerifyFields(business))
                {
                    BusinessConnection.DeleteBusiness(int.Parse(idBusiness));
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

        public static BusinessModel SelectBusinessById(string idBusiness)
        {
            try
            {
                //TEMP
                string[] business = new string[] { idBusiness };
                BusinessModel businessModel = new BusinessModel()
                {
                    IdBusiness = int.Parse(idBusiness)
                };
                if (VerifyFields(business))
                {
                    return BusinessConnection.SelectBusiness(businessModel);
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

        public static List<BusinessModel> SelectAllBusiness()
        {
            try
            {
                return BusinessConnection.SelectAllBusiness();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
