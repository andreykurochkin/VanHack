using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VanHack;

namespace VanHackUnitTestProject {
    [TestClass]
    public class PeakNumberTests {
        [TestMethod]
        public void Constructor_NegativeValue_ReturnsError() {
            try {
                var negativeValue = -10;
                var peakNumer = new PeakNumber(negativeValue);
            }
            catch (Exception ex) {
                Assert.AreEqual(ex.Message, "time starts from 1");
            }
        }
        [TestMethod]
        public void Constructor_OutOfRangeValue_ReturnError() {
            try {
                var maxValue = int.MaxValue;
                var peakNumer = new PeakNumber(maxValue);
            }
            catch (Exception ex) {
                Assert.AreEqual(ex.Message, "value is too big");
            }
        }
        [TestMethod]
        public void Constructor_GoodValue_ReturnTrue() {
            var goodValue = 100;
            var result = new PeakNumber(goodValue);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Value_11_ReturnsTrue() {
            var peakTime = new PeakTime(1);
            var result = peakTime.Value;
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void Value_12_ReturnsTrue() {
            var peakTime = new PeakTime(2);
            var result = peakTime.Value;
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void Value_13_ReturnsTrue() {
            var peakTime = new PeakTime(3);
            var result = peakTime.Value;
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void Value_21_ReturnsTrue() {
            var peakTime = new PeakTime(4);
            var result = peakTime.Value;
            Assert.IsTrue(result == 4);
        }
        [TestMethod]
        public void Value_22_ReturnsTrue() {
            var peakTime = new PeakTime(6);
            var result = peakTime.Value;
            Assert.IsTrue(result == 4);
        }
        [TestMethod]
        public void Value_23_ReturnsTrue() {
            var peakTime = new PeakTime(9);
            var result = peakTime.Value;
            Assert.IsTrue(result == 4);
        }
        [TestMethod]
        public void Value_31_ReturnsTrue() {
            var peakTime = new PeakTime(10);
            var result = peakTime.Value;
            Assert.IsTrue(result == 10);
        }
        [TestMethod]
        public void Value_32_ReturnsTrue() {
            var peakTime = new PeakTime(13);
            var result = peakTime.Value;
            Assert.IsTrue(result == 10);
        }
        [TestMethod]
        public void Value_33_ReturnsTrue() {
            var peakTime = new PeakTime(21);
            var result = peakTime.Value;
            Assert.IsTrue(result == 10);
        }
        [TestMethod]
        public void Value_41_ReturnsTrue() {
            var peakTime = new PeakTime(22);
            var result = peakTime.Value;
            Assert.IsTrue(result == 22);
        }
        [TestMethod]
        public void Value_42_ReturnsTrue() {
            var peakTime = new PeakTime(30);
            var result = peakTime.Value;
            Assert.IsTrue(result == 22);
        }
        [TestMethod]
        public void Value_43_ReturnsTrue() {
            var peakTime = new PeakTime(45);
            var result = peakTime.Value;
            Assert.IsTrue(result == 22);
        }
    }
}