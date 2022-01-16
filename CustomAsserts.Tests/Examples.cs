using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomAsserts;
using System;

namespace CustomAsserts.Tests
{
    [TestClass]
    public class Examples
    {
        [TestMethod]
        public void EmptyString()
        {
            string str = "Hello, world!";

            string transformed = str.Remove(0);

            Assert.That.StringIsEmpty(transformed);
        }

        [TestMethod]
        [DataRow("1234567890123456", "123")]
        public void CardHasAllValidValues(string cardNumber, string cvvOrCvc)
        {
            Assert.That.CardHasCorrectNumberValue(cardNumber);
            Assert.That.CardHasCorrectCvvOrCvcValue(cvvOrCvc);
        }


        [TestMethod]
        [DataRow("1234567890123456")]
        [DataRow("1234 5678 9012 3456")]
        [DataRow("123456789012345A")]
        [DataRow("1234 5678 9012 345A")]
        [DataRow("123")]
        [DataRow("1234567890123456123")]
        public void CardHasValidCardNumber(string cardNumber)
        {
            Assert.That.CardHasCorrectNumberValue(cardNumber);
        }

        [TestMethod]
        [DataRow("05/23")]
        [DataRow("01/53")]
        [DataRow("01/00")]
        [DataRow("05/233")]
        [DataRow("1/23")]
        [DataRow("00/23")]
        [DataRow("14/23")]
        public void CardHasValidDate(string date)
        {
            Assert.That.CardHasCorrectDateValue(date);
        }

        [TestMethod]
        [DataRow("123")]
        [DataRow("098")]
        [DataRow("12")]
        [DataRow("1234")]
        [DataRow("12a")]
        public void CardHasValidCVVOrCVC(string cvvOrCvc)
        {
            Assert.That.CardHasCorrectCvvOrCvcValue(cvvOrCvc);
        }

        [TestMethod]
        [DataRow(100, 50)]
        [DataRow(50, 100)]
        public void WithdrawalIsValid(int balance, int withdrawalAmount)
        {
            Assert.That.AbleToWithdraw(balance, withdrawalAmount);
        }

        [TestMethod]
        [DataRow(200)]
        [DataRow(0)]
        [DataRow(-50)]
        public void DepositIsValid(int depositAmount)
        {
            Assert.That.AbleToDeposit(depositAmount);
        }
    }
}