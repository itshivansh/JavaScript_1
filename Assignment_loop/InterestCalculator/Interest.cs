using System;

namespace InterestCalculator
{
    class Interest
    {
       public  void totalInterest()
        {
            Console.WriteLine("Enter the amount \nEnter the rate \nEnter the time");
            double amount = Convert.ToInt32(Console.ReadLine());
            double rate = Convert.ToInt32(Console.ReadLine());
            double time = Convert.ToInt32(Console.ReadLine());
            double interest = (amount * rate * time) / 100;
            Console.WriteLine("interest will be : " + interest);
        }
    }
}
