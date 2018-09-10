using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    class PositionConection
    {
        public static List<PositionModel> SelectPosition(PositionModel position)
        {
            try
            {
                //ClaseBD.SelectPosition(position);
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool InsertPosition(PositionModel position)
        {
            try
            {
                //ClaseBD.InsertPosition(position);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdatePosition(PositionModel position)
        {
            try
            {
                //ClaseBD.UpdatePosition(position);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeletePosition(PositionModel position)
        {
            try
            {
                //ClaseBD.DeletePosition(position);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
