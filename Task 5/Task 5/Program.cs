using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task5
{
    static class Robota
    {
        static int[] NewArray(int[] arrA, int[] arrB, int[] arrResult)
        {
            for (int i = 0; i < arrResult.Length; i++)
            {
                arrResult[i] = (((arrA[i] * arrA[i]) + (arrB[i] * arrB[i])) / 2);
            }

            return arrResult;
        }
        static int[] CheckForFive(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0)
                {
                    array[i] -= 8;
                }
            }
            return array;
        }

        class Program
        {
            static void Main()
            {
             try
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                int a;
                System.
                Console.Write("Как Вы хотите принимать елементи масива?(1 - з клавіатури, 2 - з файлу) = ");
                a = Int32.Parse(Console.ReadLine());

                    if (a == 1)
                    {
                        bool o = true;
                        while (o is true)
                        {
                            int b;
                            Console.WriteLine("Введите елемент массива №1 = ");
                            b = Convert.ToInt32(Console.ReadLine());
                            list1.Add(b);
                            Console.WriteLine("Вы закончили?");
                            string check;
                            check = Console.ReadLine();
                            if (check == "да")
                            {
                                foreach (int num in list1)
                                {
                                    Console.WriteLine(num);
                                }
                                break;
                            }
                        }
                        bool o1 = true;
                        while (o1 is true)
                        {
                            int a1;
                            Console.WriteLine("Введите елемент массива №2 = ");
                            a1 = Convert.ToInt32(Console.ReadLine());
                            list2.Add(a1);
                            Console.WriteLine("Вы закончили?");
                            string check2;
                            check2 = Console.ReadLine();
                            if (check2 == "да")
                            {
                                foreach (int num in list2)
                                {
                                    Console.WriteLine(num);
                                }
                                break;
                            }
                        }
                        int[] arrA = list1.ToArray();
                        int[] arrB = list2.ToArray();
                        int[] arrResult = new int[arrA.Length <= arrB.Length ? arrA.Length : arrB.Length];
                        arrA = CheckForFive(arrA);
                        arrResult = NewArray(arrA, arrB, arrResult);
                        for (int i = 0; i < arrResult.Length; i++)
                        {
                            Console.WriteLine(arrResult[i]);
                        }
                    }
                    else
                    {
                        string temp;
                        FileStream file1 = new FileStream("E:\\1masiv.txt", FileMode.Open, FileAccess.Read);
                        StreamReader wr = new StreamReader(file1);
                        while (true)
                        {
                            temp = wr.ReadLine();
                            if (temp != null)
                            {
                                list1.Add(Convert.ToInt32(temp));
                            }
                            else
                            {
                                break;
                            }
                        }
                        wr.Close();

                        FileStream file2 = new FileStream("E:\\2masiv.txt", FileMode.Open, FileAccess.Read);
                        StreamReader wr2 = new StreamReader(file2);
                        while (true)
                        {
                            temp = wr2.ReadLine();
                            if (temp != null)
                            {
                                list2.Add(Convert.ToInt32(temp));
                            }
                            else
                            {
                                break;
                            }
                        }
                        wr2.Close();
                        int[] arrA = list1.ToArray();
                        int[] arrB = list2.ToArray();
                        int[] arrResult = new int[arrA.Length <= arrB.Length ? arrA.Length : arrB.Length];
                        arrA = CheckForFive(arrA);
                        arrResult = NewArray(arrA, arrB, arrResult);
                        for (int i = 0; i < arrResult.Length; i++)
                        {
                            Console.WriteLine(arrResult[i]);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Помилка вводу");
                }
            }
        }
    }
}