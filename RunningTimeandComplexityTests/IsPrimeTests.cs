using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningTimeandComplexity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunningTimeandComplexity.Tests {
    [TestClass()]
    public class IsPrimeTests {
        [TestMethod()]
        public void ToBool_31_ReturnsTrue() {
            string n = "31";

            var result = new IsPrime(n).ToBool();
            
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ToBool_33_ReturnsTrue() {
            string n = "33";

            var result = new IsPrime(n).ToBool();

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ToBool_12_ReturnsFalse() {
            string n = "12";

            var result = new IsPrime(n).ToBool();

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ToBool_5_ReturnsTrue() {
            string n = "5";

            var result = new IsPrime(n).ToBool();

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void ToBool_7_ReturnsTrue() {
            string n = "7";

            var result = new IsPrime(n).ToBool();

            Assert.IsTrue(result);
        }
    }
}