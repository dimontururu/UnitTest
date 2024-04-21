using jokes_with_string;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestReverseString
    {
        [TestMethod]
        public void Reverse_Hello_return_olleH()
        {
            string reversible = "Hello";
            string expected = "olleH";
            ReverseString reverseString = new ReverseString();

            string inverted = reverseString.Reverse(reversible);

            Assert.AreEqual(expected, inverted);
        }

        [TestMethod]
        public void Reverse_Bye_return_eyB()
        {
            string reversible = "Bye";
            string expected = "eyB";
            ReverseString reverseString = new ReverseString();

            string inverted = reverseString.Reverse(reversible);

            Assert.AreEqual(expected, inverted);
        }
    }
}
