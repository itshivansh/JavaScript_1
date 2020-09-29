﻿using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ArmstrongNum";
            int num, rem, sum = 0, temp;
            Console.Write("Enter the Number= ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}
