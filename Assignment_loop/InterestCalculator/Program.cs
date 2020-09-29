using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Interest calculator";
            Interest n = new Interest();
            n.totalInterest();
            Console.WriteLine("Enter Y or N");
            string x = Console.ReadLine();
            while (x != "N")
            {
                n.totalInterest();
                Console.WriteLine("Enter Y or N");
                x = Console.ReadLine();
            }
        }
    }
}
