using BusinessLibrary.Conection;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BusinessManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fantasyName"></param>
        /// <param name="societyName"></param>
        /// <param name="legalCertification"></param>
        /// <param name="telephone"></param>
        /// <param name="mainAddress"></param>
        /// <param name="generalAddress"></param>
        /// <param name="email"></param>
        /// <param name="webPage"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        public static bool InsertBusiness(
            string fantasyName,
            string societyName,
            string legalCertification,
            string telephone,
            string mainAddress,
            string generalAddress,
            string email,
            string webPage,
            byte[] logo
        )
        {
            try
            {
                string[] business = new string[] {
                    fantasyName,
                    societyName,
                    legalCertification,
                    telephone, mainAddress,
                    generalAddress,
                    email,
                    webPage
                };
                if (DataManagement.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        FantasyName = fantasyName,
                        SocietyName = societyName,
                        LegalCertification = legalCertification,
                        Telephone = telephone,
                        MainAddress = mainAddress,
                        GeneralAddress = generalAddress,
                        Email = email,
                        WebPage = webPage,
                        Logo = logo
                    };
                    return BusinessConnection.InsertBusiness(businessModel);
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
        /// <param name="idBusiness"></param>
        /// <param name="fantasyName"></param>
        /// <param name="societyName"></param>
        /// <param name="legalCertification"></param>
        /// <param name="telephone"></param>
        /// <param name="mainAddress"></param>
        /// <param name="generalAddress"></param>
        /// <param name="email"></param>
        /// <param name="webPage"></param>
        /// <param name="logo"></param>
        /// <returns></returns>
        public static bool UpdateBusinessById(
            string idBusiness,
            string fantasyName,
            string societyName,
            string legalCertification,
            string telephone,
            string mainAddress,
            string generalAddress,
            string email, 
            string webPage,
            byte[] logo
        )
        {
            try
            {
                string[] business = new string[] {
                    idBusiness,
                    fantasyName,
                    societyName,
                    legalCertification,
                    telephone,
                    mainAddress,
                    generalAddress,
                    email,
                    webPage
                };
                if (DataManagement.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return BusinessConnection.UpdateBusiness(businessModel);
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

        public static bool UpdateBusinessById(
            string idBusiness,
            string fantasyName,
            string societyName,
            string legalCertification,
            string telephone,
            string mainAddress,
            string generalAddress,
            string email,
            string webPage
        )
        {
            try
            {
                string[] business = new string[] {
                    idBusiness,
                    fantasyName,
                    societyName,
                    legalCertification,
                    telephone,
                    mainAddress,
                    generalAddress,
                    email,
                    webPage
                };
                if (DataManagement.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return BusinessConnection.UpdateBusiness(businessModel);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idBusiness"></param>
        /// <returns></returns>
        public static bool DeleteBusinessById(string idBusiness)
        {
            try
            {
                string[] business = new string[] { idBusiness };
                if (DataManagement.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return BusinessConnection.DeleteBusiness(businessModel);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idBusiness"></param>
        /// <returns></returns>
        public static BusinessModel SelectBusinessById(string idBusiness)
        {
            try
            {
                //TEMP
                string[] business = new string[] { idBusiness };
                if (DataManagement.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
