using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Prime num";
            Console.WriteLine("Enter the number to be checked");
            int n = Convert.ToInt32(Console.ReadLine());
            int a=0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
                if (a == 2)
                {
                Console.WriteLine("it is a Prime Number");
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
        }
    }
}
