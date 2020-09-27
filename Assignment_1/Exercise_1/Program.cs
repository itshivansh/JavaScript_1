using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter length and breadth of the rectangle:");
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double result;
            Rectangle first = new Rectangle();
            result = first.Result(l,b);
            Console.WriteLine("Area of rectangle is ::"+result);

        }
    }
}
