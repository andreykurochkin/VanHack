using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets {
    // algorith
    // find LCM least common integer for array a
    //  find HCF highest common factor
    // get minimum element of array b
    // get 
    public class BetweenTwoSets {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }

        public static int getTotalX(List<int> a, List<int> b) {
            int factors = 0;
            int lcmA = GetLcm(a);
            int minB = b.Min();
            int hcfB = GetHcf(b);



            int suspect = lcmA;
            for (int i = 1; suspect <= minB; i++) {
                suspect = i * lcmA;
                if (hcfB % suspect == 0) {
                    factors++;
                }
            }
            return factors;
        }
        /// <summary>
        /// gets highest common factor
        /// </summary>
        public static int GetHcf(int a, int b) {
            if (a == 0) {
                return b;
            }
            // var min = Math.Min(a, b);
            // var max = Math.Max(a, b);
            return GetHcf(b % a, a);
        }
        /// <summary>
        /// gets least common factor
        /// </summary>
        public static int GetLcm(int a, int b) {
            if (a == 0) {
                return b;
            }
            return (a * b) / GetHcf(a, b);
        }
        public static int GetLcm(List<int> a) {
            int result = a[0];
            for (int i = 1; i < a.Count; i++) {
                result = GetLcm(result, a[i]);
            }
            return result;
        }
        public static int GetHcf(List<int> a) {
            int result = a[0];
            for (int i = 1; i < a.Count; i++) {
                result = GetHcf(result, a[i]);
            }
            return result;
        }
    }
}
