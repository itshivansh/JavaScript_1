using System;

namespace interestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Interest based on Age";
            Console.WriteLine("Enter the age");
            double age = Convert.ToDouble(Console.ReadLine());
            double interest;
            double amount = 23000.00;
            double rate;
            if (age >= 60)
            {
                rate = 7;
            }
            else
            {
                rate = 6;
            }
            Console.WriteLine("Deposit - Amount      InterestRate(%)      Years     Amount(SI)");
            for (double year = 1; year <= 5; year++)
            {
                interest = amount * rate * year / 100.00;
                double totalAmount = amount + interest;
                Console.WriteLine(amount.ToString("N2") + "                  " + rate + "              " + year + "          " + totalAmount.ToString("N2"));
            }

        }
    }
}
