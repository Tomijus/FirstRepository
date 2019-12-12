using System;

namespace FirstGitProject
{
    class Program
    {
        static void Main()
        {
            Max(10, 6, 15);
        }

        static void Max(int a, int b, int c)
        {
            if (a>b && a>c)
            {
                Console.WriteLine($"Didziausias yra {a}");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine($"Didziausias yra {b}");
            }
            else
            {
                Console.WriteLine($"Didziausias yra {c}");
            }
        }
    }
}
