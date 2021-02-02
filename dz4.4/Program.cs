using System;

namespace dz4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int f = Convert.ToInt32 (Console.ReadLine());
            int n = fib(f);
            Console.WriteLine(n);

        }
        static int fib(int n)
        {
            return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }
    }
}
