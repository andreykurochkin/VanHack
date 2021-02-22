using System;

namespace BreakingTheRecords {
    public class BreakingTheRecords {
        public int[] BreakingRecords(int[] scores) {
            int maxRecordValue = scores[0];
            int maxRecordCount = 0;
            int minRecordValue = scores[0];
            int minRecordCount = 0;
            for (int i = 0; i < scores.Length - 1; i++) {
                var current = scores[i];
                var next = scores[i + 1];
                if (current > next) {
                    if (next < minRecordValue) {
                        minRecordValue = next;
                        minRecordCount++;
                    }
                }
                if (current < next) {
                    if (next > maxRecordValue) {
                        maxRecordValue = next;
                        maxRecordCount++;
                    }
                }
            }
            return new int[] { maxRecordCount, minRecordCount };
        }
    }
}
