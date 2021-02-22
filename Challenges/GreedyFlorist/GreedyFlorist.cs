using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Challenges.GreedyFlorist {
    public class GreedyFlorist {
        public GreedyFlorist(int[] flowers, int friends) {
            Flowers = flowers;
            Friends = friends;
        }
        public int[] Flowers { get; }
        public int Friends { get; }
        public int GetMinimumCost(int k, int[] c) {
            var flowers = c.OrderByDescending(e => e).ToList();
            int approach = 0;
            int result = 0;
            int kCounter = 0;
            for (int i = 0; i < flowers.Count; i++) {
                result += flowers[i] * (1 + approach);
                if (kCounter == k - 1) {
                    kCounter = 0;
                    approach++;
                    continue;
                }
                kCounter++;
            }
            return result;
        }
    }
}
