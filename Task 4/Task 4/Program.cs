using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
namespace Task_4
{
    static class kolo
    {
        private static int tochkaX { get; set; }
        private static int tochkaY { get; set; }
        private static double mash { get; set; }
        private static int r { get; set; }
        private static double area { get; set; }
        private static double length { get; set; }
        public static double CalcArea(int a)
        {
            area = r * r * Math.PI;
            Console.WriteLine($"Площа кола = {area}");
            return area;
        }
        public static double CalcLength(int r)
        {
            length = 2 * r * Math.PI;
            Console.WriteLine($"Довжина кола = {length}");
            return length;
        }
        public static int EnterX(int a)
        {
            tochkaX = a;
            return tochkaX;
        }
        public static int EnterR(int a)
        {
            r = a;
            return r;
        }
        public static int EnterY(int a)
        {
            tochkaY = a;
            return tochkaY;
        }
        public static void GetInfo()
        {
            Console.WriteLine($"Точка х = {tochkaX}");
            Console.WriteLine($"Точка у = {tochkaY}");
            Console.WriteLine($"Радіус R = {r}");
            Console.WriteLine($"Масштабованна копія: x = {tochkaX} ; y = {tochkaY} ; R = {mash}");
        }
        public static double Mashtab(double a)
        {
            mash = r / a;
            return mash;
        }

        class Program
        {
            static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                int check;
                Console.Write("Как Вы хотите принимать елементи масива?(1 - з клавіатури, 2 - з файлу) = ");
                check = Int32.Parse(Console.ReadLine());
                if (check == 1)
                {
                    int a, b, c;
                    double d;
                    Console.WriteLine("Введіть x = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    kolo.EnterX(a);
                    Console.WriteLine("Введіть y = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    kolo.EnterY(b);
                    Console.WriteLine("Введіть радіус R = ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введіть масштабування 1 до ? :");
                    d = Convert.ToDouble(Console.ReadLine());
                    kolo.EnterR(c);
                    kolo.Mashtab(d);
                    kolo.GetInfo();
                    kolo.CalcArea(c);
                    kolo.CalcLength(c);
                }
                else
                {
                    int a, b, c;
                    double d;
                    List<int> list = new List<int>();
                    string temp;
                    FileStream file1 = new FileStream("E:\\x,y,R.txt", FileMode.Open, FileAccess.Read);
                    StreamReader wr = new StreamReader(file1);
                    while (true)
                    {
                        temp = wr.ReadLine();
                        if (temp != null)
                        {
                            list.Add(Int32.Parse(temp));
                        }
                        else
                        {
                            break;
                        }
                        a = list[0];
                        b = list[1];
                        c = list[2];
                        Console.WriteLine("Введіть масштабування 1 до ? :");
                        d = Convert.ToDouble(Console.ReadLine());
                        kolo.EnterR(c);
                        kolo.Mashtab(d);
                        kolo.GetInfo();
                        kolo.CalcArea(c);
                        kolo.CalcLength(c);
                    }
                    wr.Close();
                }
            }
        }
    }
}
 
