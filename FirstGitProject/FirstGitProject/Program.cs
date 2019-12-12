using System;

namespace FirstGitProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Max(10, 6, 15));
        }

        static int Max(int a, int b, int c)
        {
            if (a>b && a>c)
            {
                return a;
            }
            else if (b>c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
