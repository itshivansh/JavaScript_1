using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Enter the first num \nEnter the second num \nEnter the operator");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "+":
                    Console.WriteLine("Answer = " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Answer = " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Answer = " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Answer = " + (a / b));
                    break;
                case "%":
                    Console.WriteLine("Answer = " + (a % b));
                    break;
                default :
                    Console.WriteLine("invalid operator");
                    break;
            }
        }
    }
}
