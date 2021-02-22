using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubarrayDivision;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubarrayDivision.Tests {
    [TestClass()]
    public class SubarrayDivisionTests {
        [TestMethod()]
        public void SubarrayDivision_SampleTestCase1_ReturnsTrue() {
            var subarrayDivision = new SubarrayDivision(new List<int>() { 1, 1, 1, 1, 1, 1 }, 3, 2);

            var result = subarrayDivision.Birthday();

            Assert.AreEqual(0, result);
        }
        [TestMethod()]
        public void SubarrayDivision_SampleTestCase0_ReturnsTrue() {
            var subarrayDivision = new SubarrayDivision(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2);

            var result = subarrayDivision.Birthday();

            Assert.AreEqual(2, result);
        }
        [TestMethod()]
        public void SubarrayDivision_SampleTestCase2_ReturnsTrue() {
            var subarrayDivision = new SubarrayDivision(new List<int>() { 4 }, 4, 1);

            var result = subarrayDivision.Birthday();

            Assert.AreEqual(1, result);
        }
    }    
}