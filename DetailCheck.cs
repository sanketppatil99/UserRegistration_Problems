﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class DetailCheck
    {
        public static string reg = "^(91)[' ']?[7-9]{1}[0-9]{9}$";

        public static bool Validate(String word)
        {
            return Regex.IsMatch(word, reg);
        }
    }
}
