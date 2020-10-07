using Microsoft.VisualStudio.TestTools.UnitTesting;
using p3;

namespace P3UnitTest
{
    [TestClass]
    public class DataModTest
    {
        [TestMethod]
        public void TestDataModFilter()
        {
            int[] testLargeMode = { 10, 99, 100 };
            int[] testSmallMode = { 10, 99, 100 };
            DataMod d1 = new DataMod(97, testLargeMode);
            DataMod d2 = new DataMod(97, testSmallMode);
            d2.Toggle(false);
            int[] result = d1.Filter();
            int[] result2 = d2.Filter();
            Assert.AreEqual(result[0], 100);
            Assert.AreEqual(result2[0], 9);
        }

        [TestMethod]
        public void TestDataModScramble()
        {
            int[] testLargeMode = { 11, 95, 100 };
            int[] testSmallMode = { 10, 99, 100 };
            DataMod d1 = new DataMod(97, testLargeMode);
            int[] result = d1.Scramble(testLargeMode);
            Assert.AreEqual(result[1], 2);
        }

    }
}
