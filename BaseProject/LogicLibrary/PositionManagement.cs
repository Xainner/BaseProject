using BusinessLibrary.Conection;
using BusinessLibrary.Models;
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
                PositionModel positionModel = new PositionModel()
                {
                    IdSalary = int.Parse(idSalary),
                    PositionName = positionName
                };
                if (VerifyFields(position))
                {
                    return PositionConnection.InsertPosition(positionModel);
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

        public static bool UpdatePositionById(string idPosition, string positionName, string idSalary)
        {
            try
            {
                //TEMP
                string[] position = new string[] { idPosition, positionName };
                PositionModel positionModel = new PositionModel()
                {
                    IdSalary = int.Parse(idSalary),
                    IdPosition = int.Parse(idPosition),
                    PositionName = positionName
                };
                if (VerifyFields(position))
                {
                    return PositionConnection.UpdatePosition(positionModel);
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
                PositionModel positionModel = new PositionModel()
                {
                    IdPosition = int.Parse(idPosition)
                };
                if (VerifyFields(position))
                {
                    return PositionConnection.UpdatePosition(positionModel);
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

        public static PositionModel SelectPositionById(string idPosition)
        {
            try
            {
                //TEMP
                string[] position = new string[] { idPosition };
                PositionModel positionModel = new PositionModel()
                {
                    IdPosition = int.Parse(idPosition)
                };
                if (VerifyFields(position))
                {
                    return PositionConnection.SelectPosition(positionModel);
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
