using System;

namespace FirstGitProject
{
    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine(Max(10, 6, 15));

            Console.WriteLine(TestNumberInRange(5, 0, 10));
            Console.WriteLine(TestNumberInRange(-5, 0, 10));
            Console.WriteLine(TestNumberInRange(5, 10, 0));
            Console.WriteLine(TestNumberInRange(5, -5, 10));
            */
            Console.WriteLine(IsPrimal(5));
            Console.WriteLine(IsPrimal(3));
            Console.WriteLine(IsPrimal(4));

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(D20());
            }
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

        static bool IsPrimal(int a)
        {
            bool answer = true;
            for (int i = 2; i < a; i++)
            {
                if (a%i==0)
                {
                    answer = false;
                    break;
                }
            }
            return answer;
        }
        static int D20()
        {
            Random random = new Random();
            return random.Next(0, 20) + 1;
        }

    }
}
