using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.GreedyFlorist;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.GreedyFlorist.Tests {
    [TestClass()]
    public class GreedyFloristTests {
        [TestMethod()]
        public void GetMinimumCostTest_3Friends3Flowers_ReturnsTrue() {
            var order = new GreedyFlorist(new int[] { 2, 5, 6 }, 3);

            var price = order.GetMinimumCost(order.Friends, order.Flowers);

            Assert.AreEqual(13, price);
        }
        [TestMethod()]
        public void GetMinimumCostTest_1Friend3Flowers_ReturnsTrue() {
            var order = new GreedyFlorist(new int[] { 2, 5, 6 }, 1);

            var price = order.GetMinimumCost(order.Friends, order.Flowers);

            Assert.AreEqual((6 + 5 * (1 + 1) + 2 * (1 + 2)), price);
        }
        [TestMethod()]
        public void GetMinimumCostTest_1Friend1Flower_ReturnsTrue() {
            var order = new GreedyFlorist(new int[] { 1 }, 1);

            var price = order.GetMinimumCost(order.Friends, order.Flowers);

            Assert.AreEqual(1, price);
        }
        [TestMethod()]
        public void GetMinimumCostTest_2Friends3Flowers_ReturnsTrue() {
            var order = new GreedyFlorist(new int[] { 2, 5, 6 }, 2);

            var price = order.GetMinimumCost(order.Friends, order.Flowers);

            Assert.AreEqual(15, price);
        }
        [TestMethod()]
        public void GetMinimumCostTest_5Friends3Flowers_ReturnsTrue() {
            var order = new GreedyFlorist(new int[] { 1, 3, 5, 7, 9 }, 3);

            var price = order.GetMinimumCost(order.Friends, order.Flowers);

            Assert.AreEqual(29, price);
        }

        [TestMethod]
        public void KangarooTest1() {
            int x1 = 0;
            int v1 = 3;
            int x2 = 4;
            int v2 = 2;
            double x = (double)(v2 * x1 - v1 * x2) / (v2 - v1);
            Console.WriteLine(x);
            Console.WriteLine((x <= 10000) ? "YES" : "NO");
        }
        [TestMethod]
        public void KangarooTest2() {
            int x1 = 0;
            int v1 = 2;
            int x2 = 4;
            int v2 = 3;
            double x = (double)(v2 * x1 - v1 * x2) / (v2 - v1);
            Console.WriteLine(x);
            Console.WriteLine((x <= 10000) ? "YES" : "NO");
        }
    }
}