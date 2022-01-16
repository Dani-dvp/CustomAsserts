using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomAsserts;

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
        [DataRow("1234567890123456")]
        [DataRow("1234 5678 9012 3456")]
        [DataRow("123456789012345A")]
        [DataRow("1234 5678 9012 345A")]
        [DataRow("123")]
        [DataRow("1234567890123456123")]
        public void CardHasValidCardNumber(string cardNumber)
        {
            //string cardNumber = "123A";
            Assert.That.CardHasCorrectNumberValue(cardNumber);
        }

    }
}