using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class SubcategoryConnection
    {
        public static SubcategoryModel SelectSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //subcategory = ClaseBD.SelectSubcategory(subcategory);
                return subcategory;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SubcategoryModel> SelectAllSubcategory()
        {
            try
            {
                //ClaseBD.SelectAllSubcategory();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.InsertSubcategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.UpdateSubcategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteSubcategory(SubcategoryModel subcategory)
        {
            try
            {
                //ClaseBD.DeleteSubcategory(subcategory);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
