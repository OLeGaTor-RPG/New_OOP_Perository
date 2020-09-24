﻿using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введiть змiнну типу int");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введiть змiнну типу double");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введiть змiнну типу long");
                long c = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"a = {a}; b = {b}; c = {c}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неправильний тип данних");
            }
        }

    }
}