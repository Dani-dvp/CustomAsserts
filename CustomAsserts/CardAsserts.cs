using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomAsserts.Tests
{
    public static class CardAsserts
    {
        public static void StringIsEmpty(this Assert assert, string actual)
        {
            if (string.IsNullOrEmpty(actual))
                return;

            throw new AssertFailedException($"Expect empty string but was {actual}");
        }

        public static void CardHasCorrectNumberValue(this Assert assert, string actual)
        {
            string removeSpace = actual.Replace(" ", "");

            if (Regex.IsMatch(actual, "[a-zA-Z]+"))
                throw new AssertFailedException($"Card Number can only contain numbers");
            
            if (removeSpace.Length != 16)
                throw new AssertFailedException($"Card Number needs to contain 16 numbers");

            return;
        }

        public static void CardHasCorrectDateValue(this Assert assert, string actual)
        {
            string removeSpace = actual.Replace("/", "");
            string month = removeSpace.Substring(0, 2);
            string year = removeSpace.Substring(2);
            var dateSplit = actual.Split('/');
            

            if (Regex.IsMatch(actual, "[a-zA-Z]+"))
                throw new AssertFailedException($"Cards Valid date can only contain numbers. Was {actual}");
            
            if(dateSplit[0].Length != 2)
                throw new AssertFailedException($"The month needs to consist of two characters with the value of 01-12. Was {month}");
            
            if (Convert.ToInt32(month) < 01 || Convert.ToInt32(month) > 12)
                throw new AssertFailedException($"The month needs to be the value of 01-12. Was {month}");
            
            if(dateSplit[1].Length != 2)
                throw new AssertFailedException($"The month needs to consist of two characters with the value of 00-99. Was {year}");

            if (Convert.ToInt32(year) < 00 || Convert.ToInt32(year) > 99)
                throw new AssertFailedException($"The year needs to be the value of 00-99. Was {year}");
            
            return;
        }

        public static void CardHasCorrectCvvOrCvcValue(this Assert assert, string actual)
        {
            if (Regex.IsMatch(actual, "[a-zA-Z]+"))
                throw new AssertFailedException($"CVV/CVC can only contain numbers");
            
            if (actual.Length != 3)
                throw new AssertFailedException($"CVV/CVC needs to contain 3 numbers");

            return;
        }
    }
}
