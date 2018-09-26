using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;

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
                if (ValidateData.VerifyFields(business))
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
                    return DBBusiness.InsertBusiness(businessModel);
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
                if (ValidateData.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness),
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
                    return DBBusiness.UpdateBusiness(businessModel);
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
                if (ValidateData.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return DBBusiness.UpdateBusiness(businessModel);
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
                if (ValidateData.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return DBBusiness.DeleteBusiness(businessModel);
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
                if (ValidateData.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        IdBusiness = int.Parse(idBusiness)
                    };
                    return DBBusiness.SelectBusinessId(businessModel);
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

        public static List<BusinessModel> SelectBusinessByName(string name)
        {
            try
            {
                string[] business = new string[] { name };
                if (ValidateData.VerifyFields(business))
                {
                    BusinessModel businessModel = new BusinessModel()
                    {
                        fantasyName = name
                    };
                    return DBBusiness.SelectBusinessByName(businessModel);
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
                return DBBusiness.SelectBusinessAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
