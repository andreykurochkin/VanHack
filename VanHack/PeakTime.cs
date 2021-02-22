using System;
using System.Collections.Generic;
using System.Text;

namespace VanHack {
    /// <summary>
    /// gets the closest left peak value of time
    /// </summary>
    public class PeakTime {
        private long Time { get; }
        public long Value => ToLong();
        internal PeakNumber PeakNumber { get; set;}
        public PeakTime(long time) {
            if (time <= 0)
                throw new ArgumentException("time starts from 1");
            if (time > Math.Pow(10,12))
                throw new ArgumentException("value is too big"); ;
            Time = time;
        }
        internal long ToLong() {
            if (Time < 4) {
                PeakNumber = new PeakNumber(1);
                return 1;
            }
            for (long i = 1; i < long.MaxValue; i++) {
                var peakValue = (long)(3 * (Math.Pow(2, i - 1)-1) + 1);
                var nextPeakValue = (long)(3 * (Math.Pow(2, i + 1 - 1)-1) + 1);
                if (nextPeakValue > Time) {
                    PeakNumber = new PeakNumber(i);
                    return peakValue;
                }
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
