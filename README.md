# CustomAsserts
This is a library with Custom Asserts. Its intension is to be used as a nuGet package and make it easier to test specific banking information with already completed Assert methods. Such as for a card, payments or a user.
The Asserts are sorted for their specific tasks. We also have an example test class that show you how they work and that they work (The failures are intentional to preview what error messages you get).

Use the Asserts in your own tests! Happy testing!

## Prerequisites
Make sure you've installed the following before trying to run the project:
- Visual Studio 2022
- .NET 6.0

## How to install:
1. Create an MSTest Project
2. Manage the projects nuGet Packages
3. Search for KEOL.Asserts.DebitAsserts
4. Install
5. Add using: using CustomAsserts.Tests
6. Now use the asserts in your test, for example: Assert.That.CardHasCorrectNumberValue(string value)
