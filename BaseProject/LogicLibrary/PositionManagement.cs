using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class PositionManagement
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

        public static bool InsertPosition(string positionName, string idSalary)
        {
            try
            {
                //TEMP
                string[] position = new string[] { positionName, idSalary };
                //TEMP
                if (VerifyFields(position))
                {
                    //METHOD
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

        public static bool UpdatePositionById(string idPosition, string positionName)
        {
            try
            {
                //TEMP
                string[] position = new string[] { idPosition, positionName };
                //TEMP
                if (VerifyFields(position))
                {
                    //METHOD
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

        public static bool DeletePositionById(string idPosition)
        {
            try
            {
                //TEMP
                string[] position = new string[] { idPosition };
                //TEMP
                if (VerifyFields(position))
                {
                    //METHOD
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

        public static bool SelectPositionById(string idPosition)
        {
            try
            {
                //TEMP
                string[] position = new string[] { idPosition };
                //TEMP
                if (VerifyFields(position))
                {
                    //METHOD
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

        //public static PositionModel SelectAllPositions()
        //{
        //    try
        //    {
        //        //METHOD
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        Log4Net
        //    }
        //}
    }
}
