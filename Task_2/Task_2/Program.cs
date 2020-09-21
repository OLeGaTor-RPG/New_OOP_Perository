using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            double b;

            long c;

            string temp;
            do
            {
                Console.WriteLine("Введiть змiнну типу int");
                temp = Console.ReadLine();
            } while (!int.TryParse(temp, out a));

            do
            {
                Console.WriteLine("Введiть змiнну типу double");
                temp = Console.ReadLine();
            } while (!double.TryParse(temp, out b));

            do
            {
                Console.WriteLine("Введiть змiнну типу long");
                temp = Console.ReadLine();
            } while (!long.TryParse(temp, out c));

            Console.WriteLine($"a = {a}; b = {b}; c = {c}");
        }
    }
}