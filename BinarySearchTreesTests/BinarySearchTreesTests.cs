using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BinarySearchTrees.Tests {
    [TestClass()]
    public class BinarySearchTreesTests {
        [TestMethod()]
        public void GetHeight_SampleTestCase0_ReturnsTrue() {
            var list = new List<int>() { 3, 5, 2, 1, 4, 6, 7 };
            var tree = new BinarySearchTrees();
            Node root = null;
            for (int i = 0; i < list.Count; i++) {
                root = tree.Insert(root, list[i]);
            }

            var result = tree.GetHeight(root);

            Assert.AreEqual(3, result);
        }
        [TestMethod()]
        public void AlterGetHeight_SampleTestCase0_ReturnsTrue() {
            var list = new List<int>() { 3, 5, 2, 1, 4, 6, 7 };
            var tree = new BinarySearchTrees();
            Node root = null;
            for (int i = 0; i < list.Count; i++) {
                var val = list[i];
                root = tree.Insert(root, val);
            }

            var result = tree.GetHeight(root);

            Assert.AreEqual(3, result);

            var pairs = new List<int>();
            var query = pairs.Select(i => i%2==0 ? i : i - 1)
                .Where(i => i > 0)
                .Count();
        }
    }
}