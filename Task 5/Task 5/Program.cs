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

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                FileStream file1 = new FileStream("E:\\1masiv.txt", FileMode.Create, FileAccess.ReadWrite);
                    StreamWriter wr = new StreamWriter(file1);
                    string temp;
                    Console.WriteLine("Введіть елементи масиву №1 = ");
                    temp = Console.ReadLine();
                    wr.Write(temp); // записуємо в файл
                    wr.Close();

                    FileStream file2 = new FileStream("E:\\1masiv.txt", FileMode.Open, FileAccess.Read);
                    StreamReader wr2 = new StreamReader(file2);
                    while (true)
                    {
                        string temp1;
                        string[] res;
                        temp1 = wr2.ReadLine();
                        if (temp1 != null)
                        {
                            char[] chSeparators = new char[] { ' ' };
                            res = temp1.Split(chSeparators, StringSplitOptions.None);
                            foreach (string i in res)
                                list1.Add(Convert.ToInt32(i));
                        }
                        else
                        {
                            break;
                        }
                    }
                    wr2.Close();


                    FileStream file3 = new FileStream("E:\\2masiv.txt", FileMode.Create, FileAccess.ReadWrite);
                    StreamWriter wr3 = new StreamWriter(file3);
                    string temp2;
                    Console.WriteLine("Введіть елементи масиву №2 = ");
                    temp2 = Console.ReadLine();
                    wr3.Write(temp2); // записуємо в файл
                    wr3.Close();


                    FileStream file4 = new FileStream("E:\\2masiv.txt", FileMode.Open, FileAccess.Read);
                    StreamReader wr4 = new StreamReader(file4);
                    while (true)
                    {
                        string temp3;
                        string[] res2;
                        temp3 = wr4.ReadLine();
                        if (temp3 != null)
                        {
                            char[] chSeparators = new char[] { ' ' };
                            res2 = temp3.Split(chSeparators, StringSplitOptions.None);
                            foreach (string i in res2)
                                list2.Add(Convert.ToInt32(i));
                        }
                        else
                        {
                            break;
                        }
                    }
                    wr4.Close();
                    int[] arrA = list1.ToArray();
                    int[] arrB = list2.ToArray();
                    int[] arrResult = new int[arrA.Length <= arrB.Length ? arrA.Length : arrB.Length];
                    arrA = CheckForFive(arrA);
                    arrResult = NewArray(arrA, arrB, arrResult);
                    Console.WriteLine("Массив:");
                    for (int i = 0; i < arrResult.Length; i++)
                    {
                        Console.WriteLine(arrResult[i]);
                    }
                }
            }    
        }
    }
