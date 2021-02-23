using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2DArrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArrays.Tests {
    [TestClass()]
    public class HourGlassMaxSumArrayOfArraysTests {
        [TestMethod()]
        public void ToString_SampleOutput_ReturnsTrue() {
            var source = new int[6][];
            source[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            source[1] = new int[6] { 0, 1, 0, 0, 0, 0 };
            source[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
            source[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
            source[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
            source[5] = new int[6] { 0, 0, 1, 2, 4, 0 };

            var result = new HourGlassMaxSumArrayOfArrays(source).ToString();

            Assert.AreEqual("19", result);
        }
    }
}