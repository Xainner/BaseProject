﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class EmployeeManagement
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

        public static bool InsertEmployee(string name, string lastName, string idType, string id, string residence, string bornDate,
            string civilState, string childs, string telephone, string cellphone, string enterStore, 
            string nationality, string idPosition, string workingState, 
            string enterDate, string endDate, string obervation, byte[] photo, string nameEmergency, string cellphoneEmergency)
        {
            try
            {
                //TEMP
                string[] employee = new string[] {  name,  lastName,  idType,  id,  residence,  bornDate,
                                                    civilState,  childs,  telephone,  cellphone,  enterStore,
                                                    nationality,  idPosition,  workingState,
                                                    enterDate,  endDate,  obervation,  nameEmergency,  cellphoneEmergency };
                //TEMP
                if (VerifyFields(employee))
                {
                    //BS.InsertSalary(user);
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

        public static bool UpdateEmployeeById(string idEmployee, string name, string lastName, string idType, string id, string residence, string bornDate,
            string civilState, string childs, string telephone, string cellphone, string enterStore,
            string nationality, string idPosition, string workingState,
            string enterDate, string endDate, string obervation, byte[] photo, string nameEmergency, string cellphoneEmergency)
        {
            try
            {
                //TEMP
                string[] employee = new string[] {  idEmployee, name,  lastName,  idType,  id,  residence,  bornDate,
                                                    civilState,  childs,  telephone,  cellphone,  enterStore,
                                                    nationality,  idPosition,  workingState,
                                                    enterDate,  endDate,  obervation,  nameEmergency,  cellphoneEmergency };
                //TEMP
                if (VerifyFields(employee))
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

        public static bool DeleteEmployeeById(string idEmployee)
        {
            try
            {
                //TEMP
                string[] employee = new string[] { idEmployee };
                //TEMP
                if (VerifyFields(employee))
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

        public static bool SelectEmployeeById(string idEmployee)
        {
            try
            {
                //TEMP
                string[] employee = new string[] { idEmployee };
                //TEMP
                if (VerifyFields(employee))
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

        //public static EmployeeModel SelectAllSalaries()
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