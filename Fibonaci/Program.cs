using System;

namespace Fibonaci
{
    public class Program
    {
        static int fibonacci(int n)
        {
            int f0 = 0, f1 = 1, fn = 1;
            int i;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
        static void Main(string[] args)
        {
            int i;
            Console.Write("Day Fibonacci: \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
