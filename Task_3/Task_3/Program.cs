using System;
using System.Runtime.ConstrainedExecution;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            double b;

            long c;
;

            bool check = false;
            {
                while (check != true)
                {
                    check = true;
                    try
                    {
                        Console.WriteLine("Введіть змінну типу int");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введіть змінну типу double");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть змінну типу long");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"a = {a}; b = {b}; c = {c}");
                    }
                    catch (System.FormatException)
                    {
                        check = false;
                        Console.WriteLine("Неправильний тип");
                        Console.WriteLine("Попробуйте ще раз: ");
                    }
                }
            }
        }
    }
}