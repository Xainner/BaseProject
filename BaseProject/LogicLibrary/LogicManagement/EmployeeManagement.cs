using BusinessLibrary.Conection;
using BusinessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (DataManagement.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        Name = name,
                        LastName = lastName,
                        IdentificationType = idType,
                        Identification = id,
                        Residence = residence,
                        BornDate = bornDate,
                        CivilState = civilState,
                        Childs = childs,
                        Telephone = telephone,
                        Cellphone = cellphone,
                        EnterStore = enterStore,
                        Nationality = nationality,
                        IdPosition = int.Parse(idPosition),
                        WorkingState = workingState,
                        EnterDate = enterDate,
                        EndDate = endDate,
                        Observation = obervation,
                        NameEmergency = nameEmergency,
                        CellphoneEmergency = cellphoneEmergency,
                        Image = photo
                    };
                    return EmployeeConnection.InsertEmployee(employeeModel);
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
                if (DataManagement.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        IdEmployee = int.Parse(idEmployee),
                        Name = name,
                        LastName = lastName,
                        IdentificationType = idType,
                        Identification = id,
                        Residence = residence,
                        BornDate = bornDate,
                        CivilState = civilState,
                        Childs = childs,
                        Telephone = telephone,
                        Cellphone = cellphone,
                        EnterStore = enterStore,
                        Nationality = nationality,
                        IdPosition = int.Parse(idPosition),
                        WorkingState = workingState,
                        EnterDate = enterDate,
                        EndDate = endDate,
                        Observation = obervation,
                        NameEmergency = nameEmergency,
                        CellphoneEmergency = cellphoneEmergency,
                        Image = photo
                    };
                    return EmployeeConnection.UpdateEmployee(employeeModel);
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
                if (DataManagement.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        IdEmployee = int.Parse(idEmployee),
                    };
                    return EmployeeConnection.DeleteEmployee(employeeModel);
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
                if (DataManagement.VerifyFields(employee))
                {
                    EmployeeModel employeeModel = new EmployeeModel()
                    {
                        IdEmployee = int.Parse(idEmployee),
                    };
                    return EmployeeConnection.SelectEmployee(employeeModel);
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
                if (DataManagement.VerifyFields(employee))
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
                if (DataManagement.VerifyFields(client))
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
                return EmployeeConnection.SelectAllEmployee();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }
    }
}
