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
        public static bool InsertBrand(string name)
        {
            try
            {
                string[] brand = new string[] { name };
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                if (DataManagement.VerifyFields(brand))
                {
                    BrandConnection.InsertBrand(brandModel);
                    return true;
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
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = int.Parse(idBrand),
                    Name = name
                };
                if (DataManagement.VerifyFields(brand))
                {
                    BrandConnection.UpdateBrand(brandModel);
                    return true;
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
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = int.Parse(idBrand)
                };
                if (DataManagement.VerifyFields(brand))
                {
                    BrandConnection.DeleteBrand(brandModel);
                    return true;
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
        public static BrandModel SelectBrandById(string idBrand)
        {
            try
            {
                string[] brand = new string[] { idBrand };
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = int.Parse(idBrand)
                };
                if (DataManagement.VerifyFields(brand))
                {
                    return BrandConnection.SelectBrand(brandModel);
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
