using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetweenTwoSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetweenTwoSets.Tests {
    [TestClass()]
    public class BetweenTwoSetsTests {
        [TestMethod()]
        public void GetHcf_SameIntegers_ReturnsTrue() {
            int a = 1;
            int b = 1;

            var result = BetweenTwoSets.GetHcf(a, b);

            Assert.AreEqual(1, result);
        }
        [TestMethod()]
        public void GetHcf_DifferentIntegers_ReturnsTrue() {
            int a = 2;
            int b = 4;

            var result = BetweenTwoSets.GetHcf(a, b);

            Assert.AreEqual(2, result);
            Assert.AreEqual(6, BetweenTwoSets.GetHcf(30, 18));
        }
        [TestMethod]
        public void GetLcf_SameIntegers_ReturnsTrue() {
            int a = 2;
            int b = 2;

            var result = BetweenTwoSets.GetLcm(a, b);

            Assert.AreEqual(2, result);
            Assert.AreEqual(68, BetweenTwoSets.GetLcm(34, 68));
        }
        [TestMethod]
        public void GetLcf_2Ints_ReturnsTrue() {
            var a = new List<int>() { 1, 3 };

            var result = BetweenTwoSets.GetLcm(a);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void GetLcf_3Ints_ReturnsTrue() {
            var a = new List<int>() { 1, 3, 9 };

            var result = BetweenTwoSets.GetLcm(a);

            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void GetTotalX_DefaultTestCase_ReturnsTrue() {
            var a = new List<int>() { 2, 6 };
            var b = new List<int>() { 24, 48 };

            var result = BetweenTwoSets.getTotalX(a, b);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void GetTotalX_SampleTestCase1_ReturnsTrue() {
            var a = new List<int>() { 3, 4};
            var b = new List<int>() { 24, 48};

            var result = BetweenTwoSets.getTotalX(a, b);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void GetTotalX_SampleTestCase0_ReturnsTrue() {
            var a = new List<int>() { 2, 4 };
            var b = new List<int>() { 16, 32, 96 };

            var result = BetweenTwoSets.getTotalX(a, b);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void GetHcf_ZeroArray_ReturnsTrue() {
            var a = new List<int>() { 0 };

            var result = BetweenTwoSets.GetHcf(a);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void GetHcf_OneArray_ReturnsTrue() {
            var a = new List<int>() { 1 };

            var result = BetweenTwoSets.GetHcf(a);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void GetHcf_TwoArray_ReturnsTrue() {
            var a = new List<int>() { 2, 4 };

            var result = BetweenTwoSets.GetHcf(a);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Tt() {
            var list = new List<int>() { 1, 0, 2, 0, 3, 4, 0, 0, 9 };
            Console.WriteLine("before");
            list.ForEach(i => Console.WriteLine(i));
            var index = 0;
            var cou = 0;
            for(int i = 0; i<list.Count; i++) {
                if (list[i] != 0) {
                    list[index] = list[i];
                    index++;
                    cou++;
                }
            }
            Console.WriteLine("after");
            list.ForEach(i => Console.WriteLine(i));
        }
    }
}