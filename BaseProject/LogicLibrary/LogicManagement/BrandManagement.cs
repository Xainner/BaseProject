using BusinessLibrary.Conection;
using BusinessLibrary.Models;
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
        public static bool InsertBusiness(string name)
        {
            try
            {
                string[] brand = new string[] { name };
                if (DataManagement.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        Name = name,
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
                if (DataManagement.VerifyFields(brand))
                {
                    BrandModel brandModel = new BrandModel()
                    {
                        IdBrand = int.Parse(idBrand)
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
                if (DataManagement.VerifyFields(brand))
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
                if (DataManagement.VerifyFields(brand))
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<BrandModel> SelectAlBrands()
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
