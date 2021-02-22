using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesbyMatch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesbyMatch.Tests {
    [TestClass()]
    public class SalesbyMatchTests {
        [TestMethod()]
        public void SockMerchant_TestCase0_ReturnsTrue() {
            var ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            var sockMerchant = new SalesbyMatch();

            var result = sockMerchant.AlterSockMerchant(ar.Length, ar);

            Assert.AreEqual(3, result);
        }
        [TestMethod()]
        public void SockMerchant_TestCase8_ReturnsTrue() {
            var ar = new int[] { 10, 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            var sockMerchant = new SalesbyMatch();

            var result = sockMerchant.AlterSockMerchant(ar.Length, ar);

            Assert.AreEqual(4,result);
        }
    }
}