using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestPermutation {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }

        public static int[] LargestPermutation(int k, int[] arr) {
            var n = arr.Length;
            var maxElement = arr.Max();
            var result = arr.ToList();

            for (int i = 0; i < n; i++) {
                if (i == k) {
                    break;
                }
                var localMax = LocalMax(maxElement, i);
                if (result[i] == localMax)
                    continue;
                for (int j = i; j < n; j++) {
                    if (result[j] == localMax) {
                        int save = result[i];
                        result[i] = result[j];
                        result[j] = save;
                        break;
                    }
                }
            }
            return result.ToArray();
        }
        private static int LocalMax(int max, int k) {
            return (k > max) ? max : max - k;
        }
        public static int[] AlterLargestPermutation(int k, int[] arr) {
            int n = arr.Length;
            int[] a = new int[n];
            int[] index = new int[n + 1];
            for (int i = 0; i < n; i++) {
                a[i] = arr[i];
                index[a[i]] = i;
            }
            for (int i = 0; i < n && k > 0; i++) {
                if (a[i] == n - i) {
                    continue;
                }
                a[index[n - i]] = a[i];
                index[a[i]] = index[n - i];
                a[i] = n - i;
                index[n - i] = i;
                k--;
            }

            Console.WriteLine("a:");
            ConsolePrint(a);
            Console.WriteLine("index:");
            ConsolePrint(index);

            return a;
        }

        private static void ConsolePrint<T>(IEnumerable<T> arr) {
            foreach (T t in arr) {
                Console.WriteLine(t.ToString());
            }
        }

        public static IEnumerable<int> GetMax(int[] arr, int value) {
            for (int j = 0; j < arr.Length; j++) {
                if (arr[j] == value) {
                    yield return j;
                }
            }
        }

        public static int[] BetaLargestPermutation(int k, int[] arr) {
            var len = arr.Length;
            for (int i = 0; i < len && k > 0; i++) {
                var index = 0;
                for (int j = 0; j < len; j++) {
                    if (arr[j] == len - i) {
                        index = j;
                        break;
                    }
                }
                if (i == index) {
                    continue;
                }
                var temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
                k--;
            }
            return arr;
        }
        private static void SwapByValue(int[] source, int swapToIndex, int swapFromValue) {
            int swapFromIndex = GetIndex(source, swapFromValue);
            int cache = source[swapToIndex];
            source[swapToIndex] = source[swapFromIndex];
            source[swapFromIndex] = cache;
        }
        //private static int GetIndex(int[] source, int swapFromValue) {
        //    for (int i = 0; i < source.Length; i++) {
        //        if (source[i] == swapFromValue) {
        //            return i;
        //        }
        //    }
        //    throw new Exception();
        //}
        public static int[] GammaLargestPermutation(int k, int[] arr) {
            int absoluteMax = arr.Length;
            if (absoluteMax == 1) {
                return arr;
            }
            int localMax = absoluteMax;
            var list = new List<int>(arr).OrderByDescending(i => i).ToList();
            for (int i = 0; i < absoluteMax; i++) {

                if (arr[i] == list[i]) {
                    localMax--;
                    continue;
                }

                SwapByValue(arr, i, localMax);
                localMax--;
                k--;
                if (k == 0) break;
            }
            return arr;
        }

        public static int[] DeltaLargestPermutation(int k, int[] arr) {
            return null;
            //var lexicographicalIndexes = LexicographicalIndexes(arr);
            //for (int i = 0; i < arr.Length; i++) {
            //    int wrightIndex = GetIndex(lexicographicalIndexes, i);
            //    if (arr[i] == arr[wrightIndex]) {
            //        continue;
            //    }
            //    Swap(arr, i, wrightIndex);
            //    k--;
            //    if (k == 0) break;
            //}
            //return arr;
            //int length = arr.Length;
            //for (int i = 0; i < arr.Length; i++) {
            //    if (arr[i] == length - i) {
            //        continue;
            //    }
            //    arr[i]
            //}
        }
        public static void Swap(int[] source, int fromIndex, int toIndex) {
            int cache = source[fromIndex];
            source[fromIndex] = source[toIndex];
            source[toIndex] = cache;
        }
        private static int GetIndex(int[] source, int value) {
            for (int i = 0; i < source.Length; i++) {
                if (source[i] == value) {
                    return i;
                }
            }
            throw new Exception();
        }

        public static int[] LexicographicalIndexes(int[] arr) {
            int length = arr.Length;
            var result = new int[length];
            for (int i = 0; i < length; i++) {
                result[i] = length - arr[i];
            }
            return result;
        }

        public static int[] largestPermutation(int k, int[] arr) {
            var length = arr.Length;
            var indexes = new int[length + 1];
            for (var i = 0; i < length; i++) {
                indexes[arr[i]] = i;
            }
            for (var i = 0; i < k && i < length - 1; i++) {
                //if (arr[i] == length - i) {
                //    continue;
                //}

                if (arr[i] != length - i) {
                    int maxValue = length - i;
                    int curValueIndex = i;

                    var curValue = arr[curValueIndex];
                    var maxValueIndex = indexes[maxValue];
                    arr[curValueIndex] = maxValue;
                    arr[maxValueIndex] = curValue;
                    indexes[maxValue] = curValueIndex;
                    indexes[curValue] = maxValueIndex;
                }
            }
            return arr;
        }
    }
}
