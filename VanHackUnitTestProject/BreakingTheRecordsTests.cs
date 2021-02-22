using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingTheRecords;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BreakingTheRecords.Tests {
    [TestClass()]
    public class BreakingTheRecordsTests {
        [TestMethod()]
        public void BreakingRecords_1stCase_ReturnsTrue() {
            int[] records = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            var result = new BreakingTheRecords().BreakingRecords(records);

            Assert.AreEqual(4, result[0]);
            Assert.AreEqual(0, result[1]);
        }
        [TestMethod()]
        public void BreakingRecords_2ndCase_ReturnsTrue() {
            int[] records = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            var result = new BreakingTheRecords().BreakingRecords(records);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [TestMethod]
        public void MyTestMethod() {
            var t = Regex.Matches("azerdii", @"[aeiou]").Count;
            if (true) {

            } else {

            }
        }
    }
}