using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace View
{
    public static class ValidationHelper
    {

        public static bool LettersOnly(string input)
        {
            if (input != "" && Regex.Match(input, "^[A-z]*$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidDate(string input)
        {
            if (input != "" && Regex.Match(input, "^(((0[1-9]|[12]d|3[01])/(0[13578]|1[02])/((19|[2-9]d)d{2}))|((0[1-9]|[12]d|30)/(0[13456789]|1[012])/((19|[2-9]d)d{2}))|((0[1-9]|1d|2[0-8])/02/((19|[2-9]d)d{2}))|(29/02/((1[6-9]|[2-9]d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsPhoneValid(string input)
        {
            if (input != "" && Regex.Match(input, "^[2-9]d{4}-d{4}$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool NumberOnly(string input)
        {
            if (Regex.Match(input, @"^\d*$").Success)
            {
                return true;
            }
            return false;
        }

        //public static bool NotEmpty(string input)
        //{
        //    //string msg = "The text field can not be empty";
        //    if (input == "")
        //    {
        //        return true;
        //    }
        //    return false;


        //}

        public static bool IsEmail(string input)
        {
            if (Regex.Match(input, @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$").Success)
            {
                return true;
            }
            return false;
        }
    }
}
