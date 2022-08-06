using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTClassLibrary
{
    public class DTValidations
    {
        public Boolean IsNumeric(string value)
        {
            Regex pattern = new Regex(@"^-?\d+.?\d*$",RegexOptions.IgnoreCase);
            if (pattern.IsMatch(value))
                return true;
            else
                return false;
        }



    }
}
