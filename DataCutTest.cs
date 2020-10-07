using Microsoft.VisualStudio.TestTools.UnitTesting;
using p3;

namespace P3UnitTest
{
    [TestClass]
    public class DataCutTest
    {

        [TestMethod]
        public void TestDataCutFilter()
        {
            int[] testLargeMode = { 10, 99, 100 };
            int[] testSmallMode = { 10, 20, 99, 100 };

            DataCut d1 = new DataCut(97, testLargeMode);
            DataCut d2 = new DataCut(97, testSmallMode);
            d2.Toggle(false);
            int[] result = d1.Filter();
            int[] result2 = d2.Filter();
            Assert.AreEqual(result[0], 99);
            Assert.AreEqual(result2[0], 20);
        }

        [TestMethod]
        public void TestDataCutScramble()
        {
            int[] testLargeMode = { 10, 99, 100 };
            int[] testLargeMode2 = { 10, 1038, 4234 };
            int[] expected = { 4234, 1038 };
            DataCut d1 = new DataCut(97, testLargeMode);
            int[] result = d1.Scramble(testLargeMode);
            int[] result2 = d1.Scramble(testLargeMode2);
            Assert.AreEqual(result2[0], 4234);
        }
    }
}
