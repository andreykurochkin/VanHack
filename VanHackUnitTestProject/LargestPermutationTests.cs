using Microsoft.VisualStudio.TestTools.UnitTesting;
using LargestPermutation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LargestPermutation.Tests {
    [TestClass()]
    public class LargestPermutationTests {
        public static void ConsolePrint<T>(IEnumerable<T> arr) {
            foreach (T t in arr) {
                Console.WriteLine(t.ToString());
            }
        }
        private static void DebugPrint<T>(IEnumerable<T> arr) {
            foreach (T t in arr) {
                System.Diagnostics.Debug.WriteLine(t.ToString());
            }
        }
        [TestMethod]
        public void GammaLargestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;

            var result = Program.GammaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void GammaLargestPermutation_5Elements2Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 2;

            var result = Program.GammaLargestPermutation(k, arr);
            //DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void GammaLargestPermutation_5Elements3Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 3;

            var result = Program.GammaLargestPermutation(k, arr);
            //DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void GammLargestPermutation_NoSwap_ReturnTrueTest() {
            int[] arr = { 2, 1 };
            int k = 1;

            var result = Program.GammaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 1);
        }
        [TestMethod]
        public void GammaLargestPermutation_1Element1Swap_ReturnTrueTest() {
            int[] arr = { 2 };
            int k = 1;

            var result = Program.GammaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
        }
        [TestMethod]
        public void BetaLargestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;
            
            var result = Program.BetaLargestPermutation(k, arr);
            
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void BetaLargestPermutation_5Elements2Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 2;

            var result = Program.BetaLargestPermutation(k, arr);
            //DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void BetaLargestPermutation_5Elements3Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 3;

            var result = Program.BetaLargestPermutation(k, arr);
            //DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void BetaLargestPermutation_NoSwap_ReturnTrueTest() {
            int[] arr = { 2, 1 };
            int k = 1;

            var result = Program.BetaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 1);
        }
        [TestMethod]
        public void BetaLargestPermutation_1Element1Swap_ReturnTrueTest() {
            int[] arr = { 2 };
            int k = 1;

            var result = Program.BetaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
        }
        [TestMethod]
        public void AlterLargestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;

            var result = Program.AlterLargestPermutation(k, arr);
            DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod()]
        public void LargestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;

            var result = Program.LargestPermutation(k, arr);
            DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void LargestPermutation_5Elements2Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 2;

            var result = Program.LargestPermutation(k, arr);
            DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void LargestPermutation_3Elements1Swap_ReturnTrueTest() {
            int[] arr = { 2, 1, 3 };
            int k = 1;

            var result = Program.LargestPermutation(k, arr);
            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[1], 1);
            Assert.AreEqual(result[2], 2);
        }
        [TestMethod]
        public void LargestPermutation_DoNoSwap_ReturnTrueTest() {
            int[] arr = { 2, 1 };
            int k = 1;

            var result = Program.LargestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 1);
        }
        [TestMethod]
        public void LexicographicalIndexes_1Element_ReturnsTrue() {
            int[] arr = { 1 };

            var result = Program.LexicographicalIndexes(arr);

            Assert.AreEqual(result[0], 0);
        }
        [TestMethod]
        public void LexicographicalIndexes_5Elements_ReturnsTrue() {
            int[] arr = { 4, 2, 3, 5, 1 };

            var result = Program.LexicographicalIndexes(arr);

            Assert.AreEqual(result[0], 1);
            Assert.AreEqual(result[1], 3);
            Assert.AreEqual(result[2], 2);
            Assert.AreEqual(result[3], 0);
            Assert.AreEqual(result[4], 4);
        }
        [TestMethod]
        public void DeltaLargestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;

            var result = Program.DeltaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 2);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 4);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void DeltaLargestPermutation_5Elements2Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 2;

            var result = Program.DeltaLargestPermutation(k, arr);
            //DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void DeltaLargestPermutation_5Elements3Swaps_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 3;

            var result = Program.DeltaLargestPermutation(k, arr);
            //DebugPrint(result);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 4);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
            Assert.AreEqual(result[4], 1);
        }
        [TestMethod]
        public void DeltaLargestPermutation_NoSwap_ReturnTrueTest() {
            int[] arr = { 2, 1 };
            int k = 1;

            var result = Program.DeltaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 1);
        }
        [TestMethod]
        public void DeltaLargestPermutation_1Element1Swap_ReturnTrueTest() {
            int[] arr = { 1 };
            int k = 1;

            var result = Program.DeltaLargestPermutation(k, arr);

            Assert.AreEqual(result[0], 1);
        }
        [TestMethod()]
        public void largestPermutation_5Elements1Swap_ReturnTrueTest() {
            int[] arr = { 4, 2, 3, 5, 1 };
            int k = 1;

            var result = Program.largestPermutation(k, arr);
            DebugPrint(result);
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

            var result = Program.largestPermutation(k, arr);
            DebugPrint(result);
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

            var result = Program.largestPermutation(k, arr);
            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[1], 1);
            Assert.AreEqual(result[2], 2);
        }
        [TestMethod]
        public void largestPermutation_DoNoSwap_ReturnTrueTest() {
            int[] arr = { 2, 1 };
            int k = 1;

            var result = Program.largestPermutation(k, arr);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 1);
        }
    }
}
// { 4, 2, 3, 5, 1 }
// i = 0
// index = 4
// value = 0
// {  ,  ,  ,  ,  0, }
// i = 1
// index = 2
// value = 1
// {  ,  ,  1,  ,  0, }
// i = 2
// index = 3
// value = 2
// {  ,  ,  1,  2,  0, }
// i = 3
// index = 5
// value = 3
// {  ,  ,  1,  2,  0, 3 }
// i = 4
// index = 1
// value = 4
// {  ,  4,  1,  2,  0, 3 }