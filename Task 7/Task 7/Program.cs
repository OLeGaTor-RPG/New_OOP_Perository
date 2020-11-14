using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Markup;
using System.Runtime.CompilerServices;

namespace Task_7
{

    public enum WeatherType
    {
        NotDefined,
        Cloudy,
        Rain,
        Time_short_rain,
        Thunder,
        Snow,
        Fog,
        Sunny
    }

    class Program
    {
        public static List<int> ReadFile(string fileName)
        {
            List<int> list_temp = new List<int>();
            FileStream file2 = new FileStream("H:\\" + fileName + ".txt", FileMode.Open, FileAccess.Read);
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
                        list_temp.Add(Convert.ToInt32(i));
                }
                else
                {
                    break;
                }
            }
            wr2.Close();
            return list_temp;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var Day = new List<int>(ReadFile("temp_day"));
            var Night = new List<int>(ReadFile("temp_night"));
            var Press = new List<int>(ReadFile("press"));
            var Fall = new List<int>(ReadFile("fall"));
            WeatherType[] Type = (WeatherType[])Enum.GetValues(typeof(WeatherType));
            Random rnd = new Random();
            List<WeatherParametersDay> daysGone = new List<WeatherParametersDay>();

            for (int i = 0; i < 30; i++)
            {
                daysGone.Add(new WeatherParametersDay(Day[rnd.Next(0, 29)], Night[rnd.Next(0, 29)], Press[rnd.Next(0, 29)], Fall[rnd.Next(0, 29)], Type[rnd.Next(0, 8)]));
            }
            WeatherDays weatherDays = new WeatherDays(daysGone);
            Console.WriteLine($"Сонячних днів = {weatherDays.SunnyDays}\nКількість днів без опадів = {weatherDays.PrecipitationDays}\nМінімальна кількість опадів = {weatherDays.Min}\nМаксимальна кількість опадів = {weatherDays.Max} ");

        }
    }


    class WeatherDays
    {
        List <WeatherParametersDay> daysGone = new List <WeatherParametersDay> ();
        private int min = 0;
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        private int max = 0;
        public int Max
        {
            get { return max; }
            set { max = value; }
        }
        private int sunnyDays = 0;
        public int SunnyDays
        {
            get { return sunnyDays; }
            set { sunnyDays = value; }
        }

        private int precipitationDays = 0;
        public int PrecipitationDays
        {
            get { return precipitationDays; }
            set { precipitationDays = value; }
        }

        public WeatherDays(List<WeatherParametersDay> daysGone)
        {
            this.daysGone = daysGone;
            Check();
        }
        private void CountSunnyDays()
        {
            foreach(WeatherParametersDay weatherParametersDay in daysGone)
            {
                if (weatherParametersDay.Typeofweather == WeatherType.Sunny)
                {
                    SunnyDays++;
                }
            }
        }
        private void CountNotPrecipitationDays()
        {
            foreach (WeatherParametersDay weatherParametersDay in daysGone)
            {
                if (weatherParametersDay.Typeofweather != WeatherType.Rain && weatherParametersDay.Typeofweather != WeatherType.Thunder && weatherParametersDay.Typeofweather != WeatherType.Time_short_rain)
                {
                    PrecipitationDays++; 
                }
            }
        }

        private void MaxMin()
        {
            max = daysGone[0].Fall;
            min = daysGone[0].Fall;
            foreach (WeatherParametersDay weatherParametersDay in daysGone)
            {
                if (weatherParametersDay.Fall < min)
                {
                    min = weatherParametersDay.Fall;
                }
                else if(weatherParametersDay.Fall > max)
                {
                    max = weatherParametersDay.Fall;
                }
            }
        }

        public void Check()
        {
            MaxMin();
            CountSunnyDays();
            CountNotPrecipitationDays();
        }
    }

    class WeatherParametersDay
    {
        public WeatherParametersDay(int a, int b, int c, int d, WeatherType e)
        {
            Temp_day = a;
            Temp_night = b;
            Pressure = c;
            Fall = d;
            Typeofweather = e;
        }
        private int temp_day;
        public int Temp_day
        {
            get
            {
                return temp_day;
            }
            set
            {
                temp_day = value;
            }
        }
        public void GetTemp_day(int a)
        {
            temp_day = a;
        }
        private int temp_night;
        public int Temp_night
        {
            get
            {
                return temp_night;
            }
            set
            {
                temp_night = value;
            }
        }
        private int pressure;
        public int Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value;
            }
        }
        private int fall;
        public int Fall
        {
            get
            {
                return fall;
            }
            set
            {
                fall = value;
            }
        }
        private WeatherType typeofweather;
        public WeatherType Typeofweather
        {
            get
            {
                return typeofweather;
            }
            set
            {
                typeofweather = value;
            }
        }
        

        }
    }

