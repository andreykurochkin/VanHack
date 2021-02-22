using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.CountingValleys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.CountingValleys.Tests {
    [TestClass()]
    public class RouteTests {
        [TestMethod()]
        public void Parse_SampleTestCase0_ReturnsTrue() {
            var path = "UDDDUDUU";
            // U D D  D  U  D  U  U
            // 1 0 -1 -2 -1 -2 -1 0
            var steps = path.Length;

            var result = new Route(steps, path).Parse();

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(-1, result[3]);
            Assert.AreEqual(-2, result[4]);
            Assert.AreEqual(-1, result[5]);
            Assert.AreEqual(-2, result[6]);
            Assert.AreEqual(-1, result[7]);
            Assert.AreEqual(0, result[8]);
            Assert.AreEqual(0, result[9]);
        }
        [TestMethod()]
        public void CountingValleys_SampleTestCase0_ReturnsTrue() {
            var path = "UDDDUDUU";
            // U D D  D  U  D  U  U
            // 1 0 -1 -2 -1 -2 -1 0
            var steps = path.Length;
            var client = new Route(steps, path);
            var ints = client.Parse();

            var result = client.CountingValleys(ints);

            Assert.AreEqual(1, result);
        }
        [TestMethod()]
        public void Parse_SampleTestCase1_ReturnsTrue() {
            var path = "DDUUDDUDUUUD";
            // D  D  U  U D  D  U  D  U  U U D
            // -1 -2 -1 0 -1 -2 -1 -2 -1 0 1 0
            var steps = path.Length;

            var result = new Route(steps, path).Parse();

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(-1, result[1]);
            Assert.AreEqual(-2, result[2]);
            Assert.AreEqual(-1, result[3]);
            Assert.AreEqual(0, result[4]);
            Assert.AreEqual(-1, result[5]);
            Assert.AreEqual(-2, result[6]);
            Assert.AreEqual(-1, result[7]);
            Assert.AreEqual(-2, result[8]);
            Assert.AreEqual(-1, result[9]);
            Assert.AreEqual(0, result[10]);
            Assert.AreEqual(1, result[11]);
            Assert.AreEqual(0, result[12]);
            Assert.AreEqual(0, 0);
        }
        [TestMethod()]
        public void CountingValleys_SampleTestCase1_ReturnsTrue() {
            var path = "DDUUDDUDUUUD";
            // D  D  U  U D  D  U  D  U  U U D
            // -1 -2 -1 0 -1 -2 -1 -2 -1 0 1 0
            var steps = path.Length;
            var client = new Route(steps, path);
            var ints = client.Parse();

            var result = client.CountingValleys(ints);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void CountingValleys_SampleTestCase2_ReturnsTrue() {
            // D  D  U  U U U D D
            // -1 -2 -1 0 1 2 1 0
            var path = "DDUUUUDD";
            var steps = path.Length;
            var client = new Route(steps, path);
            var ints = client.Parse();

            var result = client.CountingValleys(ints);

            Assert.AreEqual(1, result);
        }
        [TestMethod()]
        public void Parse_SampleTestCase2_ReturnsTrue() {
            // D  D  U  U U U D D
            // -1 -2 -1 0 1 2 1 1
            var path = "DDUUUUDD";
            var steps = path.Length;

            var result = new Route(steps, path).Parse();

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(-1, result[1]);
            Assert.AreEqual(-2, result[2]);
            Assert.AreEqual(-1, result[3]);
            Assert.AreEqual(0, result[4]);
            Assert.AreEqual(1, result[5]);
            Assert.AreEqual(2, result[6]);
            Assert.AreEqual(1, result[7]);
            Assert.AreEqual(0, result[8]);
            Assert.AreEqual(0, result[9]);
        }
    }
}