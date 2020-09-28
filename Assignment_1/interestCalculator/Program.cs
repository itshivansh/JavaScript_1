using System;

namespace interestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Interest";
            double interest;
            double totalAmount;
            int age = 65;
            double rate = 12.75;
            double amount = 23000.00;
            string name = "Sam";
            Console.WriteLine("Name      Age  Deposit - Amount      InterestRate(%)      Years     Amount(SI)");
            for (double year = 1; year <= 5; year++)
            {
                interest = amount * rate * year / 100.00;
                totalAmount = amount + interest;
                Console.WriteLine(name + "       " + age + "   " + amount.ToString("N2") + "                  " + rate + "              " + year + "      " + totalAmount.ToString("N2"));
            }

        }
    }
}
