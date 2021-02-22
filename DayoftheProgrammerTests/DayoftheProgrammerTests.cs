using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayoftheProgrammer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayoftheProgrammer.Tests {
    [TestClass()]
    public class DayoftheProgrammerTests {
        [TestMethod()]
        public void DayOfProgrammer_12091984_ReturnsTrue() {
            int year = 1984;

            var dayoftheProgrammer = DayoftheProgrammer.DayOfProgrammer(year);

            Assert.AreEqual("12.09.1984", dayoftheProgrammer);
        }
        [TestMethod()]
        public void DayOfProgrammer_13092017_ReturnsTrue() {
            int year = 2017;

            var dayoftheProgrammer = DayoftheProgrammer.DayOfProgrammer(year);

            Assert.AreEqual("13.09.2017", dayoftheProgrammer);
        }
        [TestMethod()]
        public void DayOfProgrammer_13092016_ReturnsTrue() {
            int year = 2016;

            var dayoftheProgrammer = DayoftheProgrammer.DayOfProgrammer(year);

            Assert.AreEqual("12.09.2016", dayoftheProgrammer);
        }
        [TestMethod()]
        public void DayOfProgrammer_12091800_ReturnsTrue() {
            int year = 1800;

            var dayoftheProgrammer = DayoftheProgrammer.DayOfProgrammer(year);

            Assert.AreEqual("12.09.1800", dayoftheProgrammer);
        }
    }
}