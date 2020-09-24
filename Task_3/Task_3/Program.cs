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

            bool bl = false;
            {
                while (bl != true)
                {
                    bl = true;
                    try
                    {
                        Console.WriteLine("Введіть змінну типу int");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введіть змінну типу double");
                        b = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Введіть змінну типу long");
                        c = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        bl = false;
                        Console.WriteLine("Неправильний тип");
                        Console.WriteLine("Попробуйте ще раз: ");
                    }
                //Console.WriteLine($"a = {a}; b = {b}; c = {c}");
                }
            }
        }
    }
}