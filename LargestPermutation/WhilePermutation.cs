namespace LargestPermutation {
    public static class WhilePermutation {
        public static int[] largestPermuation(int k, int[] arr) {
            int n = arr.Length;
            int i, e;
            int[] I = new int[n + 1];
            for (i = 0; i < n; i++) {
                e = arr[i];
                I[e] = i;
            }
            i = 0;
            e = 0;
            while (i < k + e && i < n) {
                if (arr[i] == n - i) {
                    i++;
                    e++;
                    continue;
                }
                var indA = I[n - i];
                Swap(i, indA, arr, I);
                i++;
            }
            return arr;
        }
        private static void Swap(int i1, int i2, int[] A, int[] I) {
            var s = A[i1];
            var d = A[i2];
            I[s] = i2;
            I[d] = i1;
            A[i1] = d;
            A[i2] = s;
        }
    }
}
