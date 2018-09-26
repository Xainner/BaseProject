using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ValidateData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static bool VerifyFields(string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VerifyEmail(string email)
        {
            return email.Contains("@");
        }

        public static bool VerifyInts(int number)
        {
            return int.TryParse("123", out number);
        }

        public static bool VerifyDates(DateTime date)
        {
            return date == null;
        }
    }
}
