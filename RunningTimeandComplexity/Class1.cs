using System;

namespace RunningTimeandComplexity {
    public class IsPrime {
        private string Value { get; }
        public IsPrime(string value) {
            Value = value;
        }
        public bool ToBool() {
            var n = Convert.ToInt32(Value);
            if (n <= 1) return false;
            if (n == 2) return true;
            for (int i = 2; i * i <= n; i++) {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
