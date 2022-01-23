using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomAsserts
{
    public class Card
    {
        //Example Entity
        public string CardNumber { get; set; }
        public string Date { get; set; }
        public string CVC { get; set; }

        public Card()
        {
            CardNumber = "1234 5678 9012 3456";
            Date = "05/23";
            CVC = "123";
        }
    }
}
