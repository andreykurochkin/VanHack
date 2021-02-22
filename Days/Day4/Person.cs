using System;
using System.Collections.Generic;
using System.Text;

namespace Days.Day4 {
    public class Person {
        private int age;
        public Person(int initialAge) {
            age = initialAge;
            if (initialAge < 0) {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
        public void yearPasses() {
            age++;
        }
        public void amIOld() {
            if (age < 13) {
                Console.WriteLine("You are young.");
                return;
            }
            if (age < 18) {
                Console.WriteLine("You are a teenager.");
                return;
            }
            Console.WriteLine("You are old.");
        }
    }
}
