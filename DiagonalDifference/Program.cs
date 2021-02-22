using System;
using System.Collections.Generic;

namespace VanHack {
    public static class Program {
        static void Main(string[] args) {
            
        }

        public static int diagonalDifference(List<List<int>> arr) {
            var diagonal = 0;
            var antiDiagonal = 0;
            for (int i = 0; i < arr.Count; i++) {
                diagonal += arr[i][i];
                var j = Math.Abs(i - (arr.Count - 1));
                antiDiagonal += arr[i][j];
            }
            int k = 0;
            var b = k.IsOdd();
            return (int)Math.Abs(diagonal - antiDiagonal);
        }

        public static bool IsOdd(this int number) {
            return number % 2 != 0;
        }
    }
}
