using System;

namespace TemperatureTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TemperatureTable";
            Console.WriteLine("Sr.No" + "    " + "Temperature(Celsius)" + "    " + "Temperature(Fahrenheit)");
            int i, j, temp;
            for (i = 1; i < 12; i++)
            {
                j = (i - 1) * 10;
                temp = (9 * (j / 5)) + 32;
                Console.WriteLine(i + "             " + j + "            " + "      " + temp);
            }
        }
    }
}
