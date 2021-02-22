using System;
using System.Collections.Generic;

namespace SubarrayDivision {
    public class SubarrayDivision {
        public SubarrayDivision(List<int> list, int sum, int length) {
            List = list;
            Sum = sum;
            Length = length;
        }

        public List<int> List { get; }
        public int Sum { get; }
        public int Length { get; }
        public int Birthday() {
            return Birthday(List, Sum, Length);
        }
        private int Birthday(List<int> s, int d, int m) {
            var cou = 0;
            var sumPattern = d;
            var lengthPattern = m;
            for (int i = 0; i <= s.Count - lengthPattern; i++) {
                var localSum = 0;
                for (int j = i; j < lengthPattern + i; j++) {
                    localSum += s[j];
                }
                if (localSum == sumPattern) {
                    cou++;
                }
            }
            return cou;
        }
    }
}
