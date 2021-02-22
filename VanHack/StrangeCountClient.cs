namespace VanHack {
    /// <summary>
    /// gets the number for specified time
    /// </summary>
    public class StrangeCountClient {
        private long Time { get; }
        public long Value { get; }
        public StrangeCountClient(long time) {
            Time = time;
            Value = ToLong(Time);
        }
        private long ToLong(long time) {
            var peakTime = new PeakTime(time);
            var timeDelta = Time - peakTime.ToLong();
            return peakTime.PeakNumber.Value - timeDelta;
        }
    }
}
