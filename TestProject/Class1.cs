using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Class1
    {
        public static bool Validation(string field1, string field2, string field3)
        {
        
            if (field1.Length >= 3 && field1.Length <= 15 && field2.Length >= 2 && field2.Length <= 25 && System.Text.RegularExpressions.Regex.IsMatch(field3, @"\+[\d]-[\d]{3}-[\d]{3}-[\d]{2}-[\d]{2}"))
            {
                return true;

            }

            else
            {
                return false;
            }
        }
    }
}
