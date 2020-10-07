using Microsoft.VisualStudio.TestTools.UnitTesting;
using p3;

namespace P3UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalidPrimeNumber()
        {
            int[] testArray = { 10, 99, 18, 88, 2 };
            DataFilter d1 = new DataFilter(98, testArray);
            int[] result = d1.Filter();
            int[] expected = { 107 };
            Assert.AreEqual(result[0], expected[0]);
        }

        [TestMethod]
        public void TestFilterFunction()
        {
            int[] testLargeMode = { 10, 99 };
            int[] testSmallMode = { 99, 10 };
            DataFilter d1 = new DataFilter(97, testLargeMode);
            DataFilter d2 = new DataFilter(97, testSmallMode);
            d2.Toggle(false);
            int[] result = d1.Filter();
            int[] result2 = d2.Filter();
            Assert.AreEqual(result[0], 99);
            Assert.AreEqual(result2[0], 10);
        }
        [TestMethod]

        public void TestOddArrayScrambleFunction()
        {
            int[] testLargeMode = { 10, 99, 100 };
            DataFilter d1 = new DataFilter(97, testLargeMode);
            int[] result = d1.Scramble(testLargeMode);
            Assert.AreEqual(result[0], 99);
        }
    }
}
