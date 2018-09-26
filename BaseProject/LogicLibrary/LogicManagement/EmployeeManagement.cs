using BusinessLibrary.Models;
using DataBaseLibrary;
using System;
using System.Collections.Generic;

namespace LogicLibrary
{
    public class EmployeeManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="idType"></param>
        /// <param name="id"></param>
        /// <param name="residence"></param>
        /// <param name="bornDate"></param>
        /// <param name="civilState"></param>
        /// <param name="childs"></param>
        /// <param name="telephone"></param>
        /// <param name="cellphone"></param>
        /// <param name="enterStore"></param>
        /// <param name="nationality"></param>
        /// <param name="idPosition"></param>
        /// <param name="workingState"></param>
        /// <param name="enterDate"></param>
        /// <param name="endDate"></param>
        /// <param name="obervation"></param>
        /// <param name="photo"></param>
        /// <param name="nameEmergency"></param>
        /// <param name="cellphoneEmergency"></param>
        /// <returns></returns>
        public static bool InsertEmployee(
            string name,
            string lastName,
            string idType,
            string id,
            string residence,
            string bornDate,
            string civilState,
            string childs,
            string telephone,
            string cellphone,
            string enterStore,
            string nationality,
            string idPosition,
            string workingState,
            string enterDate,
            string obervation,
            byte[] photo,
            string nameEmergency,
            string cellphoneEmergency
        )
        {
            try
            {
                string[] employee = new string[] {
                    name,
                    lastName,
                    idType,
                    id,
                    residence,
                    bornDate,
                    civilState,
                    childs,
                    telephone,
                    cellphone,
                    enterStore,
                    nationality,
                    idPosition,
                    workingState,
                    enterDate,
                    obervation,
                    nameEmergency,
                    cellphoneEmergency
                };
                if (ValidateData.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        Name = name,
                        LastName = lastName,
                        IdentificationType = idType,
                        Identification = id,
                        Residence = residence,
                        BornDate = DateTime.Parse(bornDate),
                        CivilState = civilState,
                        Childs = childs,
                        Telephone = telephone,
                        Cellphone = cellphone,
                        EnterStore = enterStore,
                        Nationality = nationality,
                        IdPosition = int.Parse(idPosition),
                        WorkingState = workingState,
                        EnterDate = DateTime.Parse(enterDate),
                        Observation = obervation,
                        NameEmergency = nameEmergency,
                        CellphoneEmergency = cellphoneEmergency,
                        Image = photo
                    };
                    return DBEmployee.InsertEmployee(employeeModel);
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
        /// <param name="idEmployee"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="idType"></param>
        /// <param name="id"></param>
        /// <param name="residence"></param>
        /// <param name="bornDate"></param>
        /// <param name="civilState"></param>
        /// <param name="childs"></param>
        /// <param name="telephone"></param>
        /// <param name="cellphone"></param>
        /// <param name="enterStore"></param>
        /// <param name="nationality"></param>
        /// <param name="idPosition"></param>
        /// <param name="workingState"></param>
        /// <param name="enterDate"></param>
        /// <param name="endDate"></param>
        /// <param name="obervation"></param>
        /// <param name="photo"></param>
        /// <param name="nameEmergency"></param>
        /// <param name="cellphoneEmergency"></param>
        /// <returns></returns>
        public static bool UpdateEmployeeById(
            string idEmployee,
            string name,
            string lastName,
            string idType,
            string id,
            string residence,
            string bornDate,
            string civilState,
            string childs,
            string telephone,
            string cellphone,
            string enterStore,
            string nationality,
            string idPosition,
            string workingState,
            string enterDate,
            string endDate,
            string obervation,
            byte[] photo,
            string nameEmergency,
            string cellphoneEmergency
        )
        {
            try
            {
                string[] employee = new string[] {
                    idEmployee,
                    name,
                    lastName,
                    idType,
                    id,
                    residence,
                    bornDate,
                    civilState,
                    childs,
                    telephone,
                    cellphone,
                    enterStore,
                    nationality,
                    idPosition,
                    workingState,
                    enterDate,
                    endDate,
                    obervation,
                    nameEmergency,
                    cellphoneEmergency
                };
                if (ValidateData.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        IdEmployee = int.Parse(idEmployee),
                        Name = name,
                        LastName = lastName,
                        IdentificationType = idType,
                        Identification = id,
                        Residence = residence,
                        BornDate = DateTime.Parse(bornDate),
                        CivilState = civilState,
                        Childs = childs,
                        Telephone = telephone,
                        Cellphone = cellphone,
                        EnterStore = enterStore,
                        Nationality = nationality,
                        IdPosition = int.Parse(idPosition),
                        WorkingState = workingState,
                        EnterDate = DateTime.Parse(enterDate),
                        EndDate = DateTime.Parse(endDate),
                        Observation = obervation,
                        NameEmergency = nameEmergency,
                        CellphoneEmergency = cellphoneEmergency,
                        Image = photo
                    };
                    return DBEmployee.UpdateEmployee(employeeModel);
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
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        public static bool DeleteEmployeeById(string idEmployee)
        {
            try
            {
                string[] employee = new string[] { idEmployee };
                if (ValidateData.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        IdEmployee = int.Parse(idEmployee),
                    };
                    return DBEmployee.DeleteEmployee(employeeModel);
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
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        public static EmployeeModel SelectEmployeeById(string idEmployee)
        {
            try
            {
                string[] employee = new string[] { idEmployee };
                if (ValidateData.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        IdEmployee = int.Parse(idEmployee),
                    };
                    return DBEmployee.SelectidEmployee(employeeModel);
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


        public static EmployeeModel SelectEmployeeByIdentification(string id)
        {
            try
            {
                string[] employee = new string[] { id };
                if (ValidateData.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        Identification = id
                    };
                    //return EmployeeConnection.SelectEmployeeByIdentification(employeeModel);
                    return null;
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
        /// <param name="toSearch"></param>
        /// <returns></returns>
        public static EmployeeModel SelecEmployeeByNameOrLastName(string toSearch)
        {
            try
            {
                string[] client = new string[] { toSearch };
                if (ValidateData.VerifyFields(client))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        Name = toSearch,
                        LastName = toSearch
                    };
                    //return EmployeeConnection.SelectEmployeeByNameOrLastName(employeeModel);
                    return null;
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
        public static List<EmployeeModel> SelectAllEmployees()
        {
            try
            {
                return DBEmployee.SelectEmployeeAll();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
