using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstUniqueCharacterInAString;

namespace UnitTestsFirstUniqueCharacterInAString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program firstUniqCharacterFinder = new Program();
            string testString = "india";
            Assert.AreEqual(firstUniqCharacterFinder.FirstUniqueCharacter(testString), 1);
            testString = "karnataka";
            Assert.AreEqual(firstUniqCharacterFinder.FirstUniqueCharacter(testString), 2);
        }
    }
}
