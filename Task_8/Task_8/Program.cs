using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть реальну частину, уявну = ");
            Complex v1 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введіть реальну частину, уявну = ");
            Complex v2 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());
            Complex v3 = v1 / v2;
            Console.WriteLine(v3.ToString());
            Complex v4 = v1 / 8;
            Console.WriteLine(v4.ToString());
            Complex v5 = v1 / 5.5;
            Console.WriteLine(v5.ToString());
        }
    }
    class Complex
    {
        public override string ToString()
        {
            if (Im < 0)
                return "Комп.число = " + Re + Im + "i";
            else
                return "Комп.число = " + Re + "+" + Im + "i";
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double re;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        private double im;

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public Complex(int Re = 0, int Im = 0)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public static Complex operator /(Complex v1, Complex v2)
        {
            return new Complex { Re = v1.Re * v2.Re, Im = v1.Im * v2.Im };
        }

        public static Complex operator /(Complex v1,  double x)
        {
            return new Complex { Re = v1.Re * x,Im = v1.Im * x , };
        }

        public static Complex operator /(double x, Complex v1)
        {
            return new Complex { Re = v1.Re * x, Im = v1.Im * x };
        }
        public static Complex operator /(int x, Complex v1)
        {
            return new Complex { Re = v1.Re * x, Im = v1.Im * x };
        }
        public static Complex operator /(Complex v1, int x)
        {
            return new Complex { Re = v1.Re * x, Im = v1.Im * x };
        }
        public static Complex operator -(Complex v1)
        {
            return new Complex { Re = -v1.Re, Im = -v1.Im };
        }
    }
} 
