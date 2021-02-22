using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetweenTwoSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Tests {
    [TestClass()]
    public class LinkedListTests {
        [TestMethod()]
        public void Main_ReturnsTrue() {
            LinkedList.Program.Main(new string[] { "1", "11", "12" });
            //Assert.Fail();
        }

        [TestMethod()]
        public void Insert_ReturnsTrue() {
            Assert.Fail();
        }

        [TestMethod()]
        public void Display_ReturnsTrue() {
            Assert.Fail();
        }
    }
}