using System;
using System.Collections.Generic;
using System.Text;

namespace VanHack {
    /// <summary>
    /// gets the closest left peak number
    /// </summary>
    public class PeakNumber {
        private long Generation { get; }
        public long Value { get; }
        public PeakNumber(long generation) {
            Generation = generation;
            Value = ToLong(generation);
        }
        internal long ToLong(long generation) {
            return (long)(3 * Math.Pow(2, generation - 1));
        }
    }
}
