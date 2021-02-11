using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EdabitTest.Medium
{
    class ATMPINCodeValidation
    {
        public static bool ValidatePin(string pin) => Regex.IsMatch(pin, @"^[0-9]+$");
    }
}
