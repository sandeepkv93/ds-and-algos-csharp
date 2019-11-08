using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongestCommonSubstring;

namespace LongestCommonSubstringUnitTests
{
    [TestClass]
    public class LCSTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 20;
            Program lcs = new Program();
            int sum = lcs.AddTwoNumbers(a, b);
            Assert.AreEqual(sum, a + b);
        }
    }
}
