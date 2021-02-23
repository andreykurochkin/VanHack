using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2DArrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArrays.Tests {
    [TestClass()]
    public class HourGlassMaxSumTests {
        [TestMethod()]
        public void ToString_SampleOutput_ReturnsTrue() {
            var source = new int[,] {
                { 1, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0, 0 },
                { 0, 0, 2, 4, 4, 0 },
                { 0, 0, 0, 2, 0, 0 },
                { 0, 0, 1, 2, 4, 0 },
            };

            var result = new HourGlassMaxSum(source).ToString();

            Assert.AreEqual("19", result);
        }
    }
}