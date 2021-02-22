using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VanHack;
using System.Linq;

namespace VanHackUnitTestProject {

    [TestClass]
    public class DiagonalDifferenceTests {
        [TestMethod]
        public void DiagonalDifference_GoodInput_ReturnsTrue() {
            var arr = new List<List<int>>();

            arr.Add(new List<int>() { 11, 2, 4 });
            arr.Add(new List<int>() { 4, 5, 6 });
            arr.Add(new List<int>() { 10, 8, -12 });

            //arr[0][0] = 11;
            //arr[0][1] = 2;
            //arr[0][2] = 4;

            //arr[1][0] = 4;
            //arr[1][1] = 5;
            //arr[1][2] = 6;

            //arr[2][0] = 10;
            //arr[2][1] = 8;
            //arr[2][2] = -2;

            var result = Program.diagonalDifference(arr);

            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void PlusMinus_GoodInput_ReturnTrue() {
            var arr = new int[] { -4, 3, -9, 0, 4, 1 };
            var p = 0;
            var n = 0;
            var z = 0;
            foreach (int i in arr) {
                if (i > 0) {
                    p++;
                    continue;
                }
                if (i < 0) {
                    n++;
                    continue;
                }
                z++;
            }
            Console.WriteLine("{0:0.000000}", (double)p / arr.Length);
            Console.WriteLine("{0:0.000000}", (double)n / arr.Length);
            Console.WriteLine("{0:0.000000}", (double)z / arr.Length);
        }

        [TestMethod]
        public void Staircase_GoodInput_ReturTrue() {
            var n = 6;
            var arr = new int[n];
            for (int i = 1; i <= n; i++) {
                Console.Write(new String(Convert.ToChar(" "), n - i));
                Console.WriteLine(new String(Convert.ToChar("#"), i));
            }
        }
    }
}