using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    Console.WriteLine("Введiть змiнну типу int");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a.GetType() != typeof(int))
                    {
                        Console.WriteLine($"Неправильний тип {a} ");
                    }
                    Console.WriteLine("Введiть змiнну типу double");
                    double b = Convert.ToDouble(Console.ReadLine());
                    if (b.GetType() != typeof(double))
                    {
                        Console.WriteLine($"Неправильний тип {b} ");
                    }
                    Console.WriteLine("Введiть змiнну типу long");
                    long c = Convert.ToInt64(Console.ReadLine());
                    if (c.GetType() != typeof(long))
                    {
                        Console.WriteLine($"Неправильний тип {c} ");
                    }
                    Console.WriteLine($"a = {a}; b = {b}; c = {c}");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Неправильний тип данних");
                }
            }

        }
    }