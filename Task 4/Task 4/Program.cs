using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
namespace Task_4
{
    class kolo
    {
        private int tochkaX { get; set; }
        private int tochkaY { get; set; }
        public int r;
        public double area;
        public double length;
        public double CalcArea(int a)
        {
            area = r * r * Math.PI;
            Console.WriteLine($"Площа кола = {area}");
            return area;
        }
        public double CalcLength(int a)
        {
            length = 2 * r * Math.PI;
            Console.WriteLine($"Довжина кола = {length}");
            return length;
        }
        public int EnterX(int a)
        {
            tochkaX = a;
            return tochkaX;
        }
        public int EnterR(int a)
        {
            r = a;
            return r;
        }
        public int EnterY(int a)
        {
            tochkaY = a;
            return tochkaY;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Точка х = {tochkaX}");
            Console.WriteLine($"Точка у = {tochkaY}");
            Console.WriteLine($"Радіус R = {r}");
        }
    }
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            kolo kola = new kolo();
            Console.WriteLine("Введіть радіус x = ");
            a = Convert.ToInt32(Console.ReadLine());
            kola.EnterX(a);
            Console.WriteLine("Введіть радіус y = ");
            b = Convert.ToInt32(Console.ReadLine());
            kola.EnterY(b);
            Console.WriteLine("Введіть радіус R = ");
            c = Convert.ToInt32(Console.ReadLine());
            kola.EnterR(c);
            kola.GetInfo();
            kola.CalcArea(c);
            kola.CalcLength(c);
        }
    }
}
 
