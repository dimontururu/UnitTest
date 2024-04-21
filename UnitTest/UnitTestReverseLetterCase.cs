using jokes_with_string;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestReverseLetterCase
    {
        [TestMethod]
        public void Reverse_HeLlo_return_hElLO()
        {
            string reversible = "HeLlo";
            string expected = "hElLO";
            ReverseLetterCase reverseString = new ReverseLetterCase();

            string inverted = reverseString.Reverse(reversible);

            Assert.AreEqual(expected, inverted);
        }

        [TestMethod]
        public void Reverse_Error()
        {
            string reversible = "ДиМа";
            string expected = "дИмА";
            ReverseLetterCase reverseString = new ReverseLetterCase();

            string inverted = reverseString.Reverse(reversible);

            Assert.AreEqual(expected, inverted);
        }
    }
}
