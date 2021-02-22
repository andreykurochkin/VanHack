using System;
using System.Linq;
using System.Collections.Generic;
namespace SalesbyMatch {
    public class SalesbyMatch {
        public int SockMerchant(int n, int[] ar) {
            var pairs = new int[100];
            for (int i = 0; i < n; i++) {
                var value = ar[i];
                pairs[value] += 1;
            }
            var query = pairs.Where(i => i > 0).Select(i => i % 2 == 0 ? i : i - 1);
            return query.Sum() / 2;
        }

        public int AlterSockMerchant(int n, int[] ar) {
            var dict = new Dictionary<int, int>();
            foreach (var key in ar) {
                if (!dict.ContainsKey(key)) {
                    dict.Add(key, 1);
                } else {
                    dict[key] += 1;
                }
            }
            var list = dict.Values.ToList().Select(i=> i/2);
            return list.Sum();
        }
    }
}
