using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomAsserts.Tests
{
    public static class UserAsserts
    {
        public static void UserNameIsValid(this Assert assert, string userName)
        {
            if (Regex.IsMatch(userName, "[a-zA-Z]+") || Regex.IsMatch(userName, "[0-9+]"))
                return;
            throw new AssertFailedException($"Username {userName} is not a valid username");
        }
        public static void UserNameIsUnderTenCharactersLong(this Assert assert, string userName)
        {
            if (userName.Length <= 10 && userName.Length > 0)
                return;
            throw new AssertFailedException($"Your username cannot exceed ten characters");
        }
        public static void UserNameIsUnderTwentyCharactersLong(this Assert assert, string userName)
        {
            if (userName.Length <= 20 && userName.Length > 0)
                return;
            throw new AssertFailedException($"Your username cannot exceed twenty characters");
        }
        public static void UserPasswordIsValid(this Assert assert, string password)
        {
            if (Regex.IsMatch(password, "[a-z+]") && Regex.IsMatch(password, "[A-Z]+"))
                return;
            throw new AssertFailedException($"Password must be greater than 8 characters and contain at least one upper case letter");
        }
        public static void UserPasswordIsOver8CharactersLong(this Assert assert, string password)
        {
            if (password.Length > 8 && password.Length > 0)
                return;
            throw new AssertFailedException($"password must be longer than 8 characters");
        }
        public static void UserEmailIsValid(this Assert assert, string userEmail)
        {
            if (Regex.IsMatch(userEmail, "@") && Regex.IsMatch(userEmail, "."))
                return;
            throw new AssertFailedException("You need to use a valid email adress");
        }
    }
}
