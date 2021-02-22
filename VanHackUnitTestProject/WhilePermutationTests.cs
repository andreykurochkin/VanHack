using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestPermutation.Tests {
    [TestClass()]
    public class WhilePermutationTests {
        [TestMethod()]
        public void largestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;

            var result = WhilePermutation.largestPermuation(k, arr);

            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void largestPermutation_5Elements2Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 2;

            var result = WhilePermutation.largestPermuation(k, arr);

            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void largestPermutation_3Elements1Swap_ReturnTrueTest() {
            int[] arr = { 2, 1, 3 };
            int k = 1;

            var result = WhilePermutation.largestPermuation(k, arr);
            LargestPermutationTests.ConsolePrint(result);

            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[1], 1);
            Assert.AreEqual(result[2], 2);
        }
        [TestMethod]
        public void largestPermutation_DoNoSwap_ReturnTrueTest() {
            int[] arr = { 2, 1 };
            int k = 1;

            var result = WhilePermutation.largestPermuation(k, arr);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 1);
        }
    }
}