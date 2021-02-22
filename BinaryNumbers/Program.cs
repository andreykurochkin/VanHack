using System;
using System.Linq;
namespace BinaryNumbers {
    public class BinaryNumbers {
        public static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
        }
        public static int Foo(int n) {
            var str = Convert.ToString(n, 2);
            var strs = str.Split('0');
            return strs.Max(i => i.Count());
        }
    }
}
