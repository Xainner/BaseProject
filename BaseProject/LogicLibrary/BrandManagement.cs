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

        //INSERT
        public static bool InsertBrand(string name)
        {
            try
            {
                string[] brand = new string[] { name };
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                if (VerifyFields(brand))
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
                return false;
                //Log4Net
            }
        }

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
                if (VerifyFields(brand))
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
                return false;
                //Log4Net
            }
        }

        public static bool DeleteBrandById(string idBrand)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idBrand };
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = int.Parse(idBrand)
                };
                if (VerifyFields(brand))
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
                return false;
                //Log4Net
            }
        }

        public static BrandModel SelectBrandById(string idBrand)
        {
            try
            {
                //TEMP
                string[] brand = new string[] { idBrand };
                BrandModel brandModel = new BrandModel()
                {
                    IdBrand = int.Parse(idBrand)
                };
                if (VerifyFields(brand))
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
                return null;
                //Log4Net
            }
        }

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
