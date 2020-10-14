using FoodMart.Services.Models;
using System;
using System.Collections.Generic;

namespace FoodMart.Services.Service
{
    public class OrderService : IOrderService
    {
        #region PriceCalculation Function
        public double PriceCalculation(string foodName,int quantity)
        {
            double cost = 0;
            if (foodName == "VegBiryani")
                cost = 150*quantity;
            else if (foodName == "MasalaDosa")
                cost = 65*quantity;
            else if (foodName == "Idli")
                cost = 50*quantity;
            else if (foodName == "Pulav")
                cost = 90*quantity;
            else if (foodName == "ChickhenBiryani")
                cost = 165*quantity;
            else if (foodName == "Kabab")
                cost = 90*quantity;
            else if (foodName == "FishCurry")
                cost = 160*quantity;
            else if (foodName == "FishBiryani")
                cost = 190*quantity;
            return cost;
        }
        #endregion

        #region Display Function
        public void BillGeneration(string customerName,string name, double totalCost)
        {
            Console.WriteLine("\nBill!!!!!!");
            Console.WriteLine($"Customer Name::{customerName}\tDate::{DateTime.Now}");
            Console.WriteLine("Your Orders");
            Console.WriteLine(name);
            Console.WriteLine("----------------------");
            Console.WriteLine($"Total cost:{totalCost}");
            Console.WriteLine("Thank you");
        }
        #endregion

        #region Total Price Calculation
        public double TotalPriceCalculation(List<double> cost)
        {
            double totalCost = 0;
            foreach (var item in cost)
                totalCost += item;
            return totalCost;
        }
        #endregion
    }
}

    

