using BusinessLibrary.Models;
using DataBaseLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class PositionManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionName"></param>
        /// <param name="idSalary"></param>
        /// <returns></returns>
        public static bool InsertPosition(string positionName, string idSalary)
        {
            try
            {
                string[] position = new string[] { positionName, idSalary };
                if (ValidateData.VerifyFields(position))
                {
                    PositionModel positionModel = new PositionModel()
                    {
                        IdSalary = int.Parse(idSalary),
                        PositionName = positionName
                    };
                    return DBPosition.InsertPosition(positionModel);
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
        /// <param name="idPosition"></param>
        /// <param name="positionName"></param>
        /// <param name="idSalary"></param>
        /// <returns></returns>
        public static bool UpdatePositionById(string idPosition, string positionName, string idSalary)
        {
            try
            {
                string[] position = new string[] { idPosition, positionName };
                if (ValidateData.VerifyFields(position))
                {
                    PositionModel positionModel = new PositionModel()
                    {
                        IdSalary = int.Parse(idSalary),
                        IdPosition = int.Parse(idPosition),
                        PositionName = positionName
                    };
                    return DBPosition.UpdatePosition(positionModel);
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
        /// <param name="idPosition"></param>
        /// <returns></returns>
        public static bool DeletePositionById(string idPosition)
        {
            try
            {
                string[] position = new string[] { idPosition };
                if (ValidateData.VerifyFields(position))
                {
                    PositionModel positionModel = new PositionModel()
                    {
                        IdPosition = int.Parse(idPosition)
                    };
                    return DBPosition.DeletePosition(positionModel);
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
        /// <param name="idPosition"></param>
        /// <returns></returns>
        public static List<PositionModel> SelectPositionById(string idPosition)
        {
            try
            {
                string[] position = new string[] { idPosition };
                if (ValidateData.VerifyFields(position))
                {
                    PositionModel positionModel = new PositionModel()
                    {
                        IdPosition = int.Parse(idPosition)
                    };
                    return DBPosition.SelectidPosition(positionModel);
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
        public static List<PositionModel> SelectAllPositions()
        {
            try
            {
                return DBPosition.SelectPositionAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
