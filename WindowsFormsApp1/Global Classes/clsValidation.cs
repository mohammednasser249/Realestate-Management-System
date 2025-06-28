using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Global_Classes
{
    public class clsValidation
    {
        public static bool ValidateEmail(string email)
        {
            var pattren = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var regx = new Regex(pattren);

            return  regx.IsMatch(email);
        }

        public static bool ValidateInteger(string Number)
        {

            return (int.TryParse(Number, out int Result));


        }

        public static bool ValidateFloat(string Number)
        {
            return (float.TryParse(Number, out float Result));

        }

        public static bool IsNumber(string input)
        {
            return double.TryParse(input, out _);
        }

    }
}
