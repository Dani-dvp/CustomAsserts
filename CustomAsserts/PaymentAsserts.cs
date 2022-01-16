using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomAsserts
{
    public class Payments
    {
        public string CardNumber { get; set; }

        public Payments()
        {
            CardNumber = "1234 5678 9012 3456";
        }
    }
}