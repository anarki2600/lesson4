using System;


namespace dz4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа, разделённые пробелами");

            string[] s = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            for (int i = 0; i<s.Length; i++)
            {
                int n = Convert.ToInt32(s[i]);
                sum += n;
            }
            Console.WriteLine(sum);

        }
    }
}
