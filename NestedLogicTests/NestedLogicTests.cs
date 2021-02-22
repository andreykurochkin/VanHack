using Microsoft.VisualStudio.TestTools.UnitTesting;
using NestedLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestedLogic.Tests {
    [TestClass()]
    public class NestedLogicTests {
        [TestMethod]
        public void GetPayment_TestCase2_ReturnsTrue() {
            var client = new NestedLogic(new DateTime(2015, 6, 9), new DateTime(2015, 6, 6));

            var result = client.GetPayment();

            Assert.AreEqual(45, result);
        }
        [TestMethod]
        public void GetPayment_TestCase1_ReturnsTrue() {
            var client = new NestedLogic(new DateTime(2010, 1, 1), new DateTime(2009, 12, 31));

            var result = client.GetPayment();

            Assert.AreEqual(10000, result);
        }
        [TestMethod]
        public void GetPayment_TestCase0_ReturnsTrue() {
            var client = new NestedLogic(new DateTime(2012, 4, 8), new DateTime(1, 1, 1));

            var result = client.GetPayment();

            Assert.AreEqual(10000, result);
        }
        [TestMethod]
        public void GetPayment_TestCase3_ReturnsTrue() {
            var client = new NestedLogic(new DateTime(2014, 12, 28), new DateTime(2015, 1, 1));

            var result = client.GetPayment();

            Assert.AreEqual(0, result);
        }
    }
}