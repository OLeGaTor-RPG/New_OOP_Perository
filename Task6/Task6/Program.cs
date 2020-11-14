using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Resolvers;

namespace Task6
{
        class Program
        {
            static void Main(string[] args)
        {
            try
            {

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("Введіть N = ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть M = ");
                int M = Convert.ToInt32(Console.ReadLine());
                int[,] massiv = new int[N, M];
                Work.EnterN(N);
                Work.EnterM(M);
                massiv = Work.FillArray(N, M);
                Work.PrintMassiv(massiv);
                Console.WriteLine("Введіть ключ:");
                Work.Search(Convert.ToInt32(Console.ReadLine()),massiv);
                Work.Product(massiv);
            }
            catch
            {
                Console.WriteLine("Помилка");
            }
        }
       
    }
        
}

