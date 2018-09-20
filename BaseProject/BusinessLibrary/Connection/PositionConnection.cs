using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Conection
{
    public class PositionConnection
    {
        public static PositionModel SelectPosition(PositionModel position)
        {
            try
            {
                //position = DBPosition.SelectPosition(position);
                return position;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<PositionModel> SelectAllPosition()
        {
            try
            {
                return DBPosition.SelectPositionAll();
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
                DBPosition.InsertPosition(position);
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
                DBPosition.UpdatePosition(position);
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
                DBPosition.DeletePosition(position);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
