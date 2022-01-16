using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CustomAsserts.Tests
{
    internal static class CustomAssert
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

    }
}
