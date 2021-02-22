using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds {
    public class MigratoryBirds {
        public static int GetMaxFrequency(List<int> arr) {
            int[] frequency = new int[arr.Count];
            for (int i = 0; i < arr.Count; i++) {
                var value = arr[i];
                frequency[value - 1]++;
            }
            var max = frequency.Max();
            for (int i = 0; i < frequency.Length; i++) {
                if (frequency[i] == max) {
                    return i + 1;
                }
            }
            throw new Exception();
        }
    }
}
