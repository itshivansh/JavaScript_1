using System;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "temperature converter";
            Console.WriteLine("Choose the scale(1 or 2) \n1. Centigrade to Farenheit \n2. Farenheit to Centigrade");
            string scale = Console.ReadLine();
            Console.WriteLine("Enter the temperaure");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (scale == "1")
            {
                double result = (9 * temperature / 5) + 32;
                Console.WriteLine("temperature in Farenheit will be" + result.ToString("N2"));
            }
            if(scale == "2"){
                double result = 5 * (temperature - 32) / 9;
                Console.WriteLine("temperature in Farenheit will be " + result.ToString("N2"));
            }
        }

    }

    }
