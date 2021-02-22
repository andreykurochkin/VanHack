using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Challenges.MarkAndToys {
    class MarkAndToys {
        public static int maximumToys(int[] prices, int k) {
            var sortedPrices = prices.OrderBy(p => p).ToList();
            var sum = 0;
            for (int i = 0; i < sortedPrices.Count(); i++) {
                sum += sortedPrices[i];
                if (sum >= k) {
                    return i;
                }
            }
            return sum;
        }
    }
}
