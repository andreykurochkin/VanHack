using Microsoft.VisualStudio.TestTools.UnitTesting;
using MigratoryBirds;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigratoryBirds.Tests {
    [TestClass()]
    public class MigratoryBirdsTests {
        [TestMethod()]
        public void GetMaxFrequency_ReturnsTrue() {
            var source = new List<int>() { 1, 4, 4, 4, 5, 3 };

            var result = MigratoryBirds.GetMaxFrequency(source);
            
            Assert.AreEqual(4, result);
        }
    }
}