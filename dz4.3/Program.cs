using System;
using System.Text.RegularExpressions;

namespace dz4._3
{
    public enum TimeYear
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    static class Method
    {
        public static String MethodYear(this TimeYear enumValue)
        {
            switch (enumValue)
            {
                case TimeYear.Winter:
                    return "Зима";
                case TimeYear.Spring:
                    return "Весна";
                case TimeYear.Summer:
                    return "Лето";
                case TimeYear.Autumn:
                    return "Осень";
                default:
                    return "null";
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {            

            Console.WriteLine("Введите порядковый номер месяца 1 - 12");
            string number = Console.ReadLine();
            string pattern = @"^(12|[1-9]?\d)$";
            while (true)
            {
                if (Regex.IsMatch(number, pattern, RegexOptions.IgnoreCase))
                {
                    goto xorosho;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            

            xorosho:
            switch (number)
            {
                case "1":
                case "12":
                case "2":
                      TimeYear month1 = TimeYear.Winter;
                      String str1 = month1.MethodYear();
                      Console.WriteLine("Сейчас " + str1);
                    break;

                case "3":
                case "4":
                case "5":
                      TimeYear month2 = TimeYear.Spring;
                      String str2 = month2.MethodYear();
                      Console.WriteLine("Сейчас " + str2);
                    break;

                case "6":
                case "7":
                case "8":
                     TimeYear month3 = TimeYear.Summer;
                     String str3 = month3.MethodYear();
                     Console.WriteLine("Сейчас " + str3);
                    break;

                case "9":
                case "10":
                case "11":
                    TimeYear month4 = TimeYear.Autumn;
                    String str4 = month4.MethodYear();
                    Console.WriteLine("Сейчас " + str4);
                    break;

            }

        }
        
    }
}
