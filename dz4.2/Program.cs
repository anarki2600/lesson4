using System;

namespace dz4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Василий ";
            string b = "Васильевич ";
            string c = "Васин ";
            string result = UserFIO(a, b, c);                /* Используем метод, чтобы вывести a b c, с ключевым словом
                                                              * params, т.к. переменный (аргументы) однотипные*/
            Console.WriteLine(result);

            string x = "Иван ";
            string y = "Иванович ";
            string z = "Иванов ";
            result = UserFIO(x, y, z);
            Console.WriteLine(result);

            string u = "Петр ";
            string v = "Петрович ";
            string w = "Петров ";
            result = UserFIO(u, v, w);
            Console.WriteLine(result);
        }
        public static string UserFIO(params string[] list)    //Метод, который принимает несколько аргументов
        {
            string result = String.Empty;
            for (int i = 0; i < list.Length; i++)
            {
                result += list[i];
            }
            return result;
        }

    }
}
