using System;

namespace FirstGitProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Max(10, 6, 15));
            Console.WriteLine(TestNumberInRange(5, 0, 10));
            Console.WriteLine(TestNumberInRange(-5, 0, 10));
            Console.WriteLine(TestNumberInRange(5, 10, 0));
            Console.WriteLine(TestNumberInRange(5, -5, 10));
        }

        static int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static bool TestNumberInRange(int testNumber, int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                Console.WriteLine("Error. Bad range values.");
            }
            return testNumber >= minValue && testNumber <= maxValue;
        }
    }
}
