using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class DetailCheck
    {
        public static string reg = "^[A-Za-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";

        public static bool Validate(String word)
        {
            return Regex.IsMatch(word, reg);
        }
    }
}
