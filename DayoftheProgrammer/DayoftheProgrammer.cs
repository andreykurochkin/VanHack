using System;

namespace DayoftheProgrammer {
    public class DayoftheProgrammer {
        public static string DayOfProgrammer(int year) {
            if (year == 1918) return new Year1918(year).ToString();
            return (year > 1918) ? new GregorianYear(year).ToString() : new JulianYear(year).ToString();
        }

        // 1700 to 1917
        public class JulianYear {
            public int Year { get; }
            public JulianYear(int year) {
                if ((year < 1700) || (year > 1917)) {
                    throw new ArgumentException();
                }
                Year = year;
            }
            public bool IsLeap() {
                return Year % 4 == 0;
            }
            public override string ToString() {
                var date = IsLeap() ? "12" : "13";
                return $"{date}.09.{Year}";
            }
        }
    }
    // 1919, 1920 ...
    public class GregorianYear {
        public int Year { get; }
        public GregorianYear(int year) {
            if (year < 1919) {
                throw new ArgumentException();
            }
            Year = year;
        }
        public bool IsLeap() {
            return (Year % 400 == 0) ? true : ((Year % 4 == 0) && (Year % 100 != 0));
        }
        public override string ToString() {
            var date = IsLeap() ? "12" : "13";
            return $"26.09.{Year}";
        }
    }
    // 1918
    public class Year1918 {
        public int Year { get; }
        public Year1918(int year) {
            if (year != 1918) {
                throw new ArgumentException();
            }
            Year = year;
        }
        public bool IsLeap() {
            return false;
        }
        public override string ToString() {
            return $"{31}.09.{Year}";
        }
    }
}
