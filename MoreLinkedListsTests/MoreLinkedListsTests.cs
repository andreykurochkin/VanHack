using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreLinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreLinkedLists.Tests {
    [TestClass()]
    public class MoreLinkedListsTests {
        [TestMethod]
        public void RemoveDuplicates_GoodData_ReturnsTrue() {
            var moreLinkedLists = new MoreLinkedLists();
            var ints = new List<int>() { 1, 2, 2, 3, 3, 4 };
            Node head = null;
            foreach (var i in ints) {
                head = moreLinkedLists.Insert(head, i);
            }
            head = moreLinkedLists.RemoveDuplicates(head);
            Assert.AreEqual(head.data, 1);
            Assert.AreEqual(head.next.data, 2);
            Assert.AreEqual(head.next.next.data, 3);
            Assert.AreEqual(head.next.next.next.data, 4);
        }
    }
}