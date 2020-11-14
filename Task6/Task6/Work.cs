using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task6
{
    static class Work
    {
        private static int N { get; set; }
        public static int n
        {
            get
            {
                return N;
            }
            set
            {
                N = value;
            }
        }
        private static int M { get; set; }
        public static int m
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }
        public static void EnterN(int a)
        {
            N = a;
        }

        public static void EnterM(int a)
        {
            M = a;
        }

        public static int[,] FillArray(int N, int M)
        {
            int[,] massiv = new int[N, M];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    massiv[i, j] = rand.Next(1, 40);
                }

            return massiv;
        }

        public static void Search(int a, int[,] massiv)
        {
            int lenght = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (a == massiv[i, j])
                    {
                        Console.WriteLine($"Елемент {massiv[i, j]} на позиції [{i},{j}]");
                        lenght++;
                    }
                }
            }
            if (lenght == 0)
            {
                Console.WriteLine("Немає такого елемента");
            }
        }

        public static void PrintMassiv(int[,] massiv)
        {
            Console.WriteLine("Mассив:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(massiv[i,j]);
                    if (massiv[i,j] < 10)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void Product(int[,] massiv)
        {
            for (int i = 0; i < N; i++)
            {
                int min = massiv[i,0];
                int max = massiv[i,0];
                for (int j = 0; j < M; j++)
                {
                    if(massiv[i,j] < min)
                    {
                        min = massiv[i, j];
                    }
                    else if(massiv[i,j] > max)
                    {
                        max = massiv[i, j];
                    }
                }
                    Console.WriteLine($"Добуток для {i+1} рядка = {min * max}");
            }
        }
    }
}
