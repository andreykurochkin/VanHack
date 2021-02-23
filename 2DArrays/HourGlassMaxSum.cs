using System;
using System.Collections.Generic;
using System.Linq;
namespace _2DArrays {
    public class HourGlassMaxSum {
        public int[,] Source { get; }
        public HourGlassMaxSum(int[,] source) {
            Source = source;
        }
        private List<int> GetSums(int[,] source) {
            var result = new List<int>();
            int sum = 0;
            for (int i = 0; i <= source.GetUpperBound(0) - 2; i++) {
                for (int j = 0; j <= source.GetUpperBound(1) - 2; j++) {
                    sum += source[i, j] + source[i, j + 1] + source[i, j + 2]
                    + source[i + 1, j + 1]
                    + source[i + 2, j] + source[i + 2, j + 1] + source[i + 2, j + 2];
                    result.Add(sum);
                    sum = 0;
                }
            }
            return result;
        }
        public override string ToString() {
            return GetSums(Source).Max().ToString();
        }
    }
    public class HourGlassMaxSumArrayOfArrays {
        public int[][] Source { get; }
        public HourGlassMaxSumArrayOfArrays(int[][] source) {
            Source = source;
        }
        private List<int> GetSums(int[][] arr) {
            var result = new List<int>();
            int sum = 0;
            for (int i = 0; i <= arr.Length - 3 ; i++) {
                for (int j = 0; j <= arr.Length - 3; j++) {
                    sum += arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                    + arr[i + 1][j + 1]
                    + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    result.Add(sum);
                    sum = 0;
                }
            }
            return result;
        }
        public override string ToString() {
            return GetSums(Source).Max().ToString();
        }
    }
}
