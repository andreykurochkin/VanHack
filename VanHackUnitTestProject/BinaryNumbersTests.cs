using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryNumbers.Tests {
    [TestClass()]
    public class BinaryNumbersTests {
        [TestMethod()]
        public void Main_ReturnsTrue() {
            int n = 125;

            int result = BinaryNumbers.Foo(n);

            Assert.AreEqual(5, result);
        }
    }
}