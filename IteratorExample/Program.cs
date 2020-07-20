using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in SomeNumbers())
            {
                Console.Write(number.ToString() + " ");
            }

            Console.WriteLine();

            foreach (int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }

            Console.WriteLine();

            DaysOfTheWeek days = new DaysOfTheWeek();

            foreach (string day in days)
            {
                Console.Write(day + " ");
            }
            // Output: Sun Mon Tue Wed Thu Fri Sat
            Console.ReadKey();
        }

        public static IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 8;
        }

        public static IEnumerable<int> EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        public class DaysOfTheWeek : IEnumerable
        {
            private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < days.Length; index++)
                {
                    // Yield each day of the week.
                    yield return days[index];
                }
            }
        }
    }
}
