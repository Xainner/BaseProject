﻿using BusinessLibrary.Conection;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BrandManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool InsertBrand(string name)
        {
            try
            {
                string[] brand = new string[] { name };
                if (ValidateData.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        Name = name
                    };
                    return BrandConnection.InsertBrand(brandModel);
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
        /// <param name="idBrand"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool UpdateBrandById(string idBrand, string name)
        {
            try
            {
                string[] brand = new string[] { idBrand, name };
                if (ValidateData.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        IdBrand = int.Parse(idBrand),
                        name = name
                    };
                    return BrandConnection.UpdateBrand(brandModel);
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
        /// <param name="idBrand"></param>
        /// <returns></returns>
        public static bool DeleteBrandById(string idBrand)
        {
            try
            {
                string[] brand = new string[] { idBrand };
                if (ValidateData.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        IdBrand = int.Parse(idBrand)
                    };
                    return BrandConnection.DeleteBrand(brandModel);
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
        /// <param name="idBrand"></param>
        /// <returns></returns>
        public static List<BrandModel> SelectBrandById(string idBrand)
        {
            try
            {
                string[] brand = new string[] { idBrand };
                if (ValidateData.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        IdBrand = int.Parse(idBrand)
                    };
                    return BrandConnection.SelectBrandName(brandModel);
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

        public static List<BrandModel> SelectBrandByName(string name)
        {
            try
            {
                string[] brand = new string[] { name };
                if (ValidateData.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        Name = name
                    };
                    return BrandConnection.SelectBrandName(brandModel);
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
        public static List<BrandModel> SelectAllBrands()
        {
            try
            {
                return BrandConnection.SelectAllBrand();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
