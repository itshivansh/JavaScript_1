using FoodMart.Services.Constants;
using FoodMart.Services.Models;
using FoodMart.Services.Service;
using System;
using System.Collections.Generic;
using System.Text;
using static FoodMart.Services.Constants.Menu;

namespace FoodMartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Title
            Console.Title = "FoodMart";
            #endregion

            #region Declarations
            OrderService orderService = new OrderService();
            MenuDisplay menuDisplay = new MenuDisplay();
            FoodOrder foodOrder = new FoodOrder();
            StringBuilder sb = new StringBuilder();
            List<double> cost = new List<double>();
            #endregion

            #region Reading Customer name
            Console.WriteLine("Welcome to FoodMart\nEnter Your Name!!");
            foodOrder.CustomerName = Console.ReadLine();
            #endregion

            #region Calling Methods
            while (true)
            {
                Console.WriteLine("\nSelect Food type");
                menuDisplay.MenuItemDisplay();
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case (int)MenuItemsChoices.Vegetarian:
                        menuDisplay.VegFoodDisplay();
                        int ch = Convert.ToInt32(Console.ReadLine());
                        foodOrder.FoodItem = Enum.GetName(typeof(Vegetarian), ch);
                        sb.Append(foodOrder.FoodItem).AppendLine();
                        Console.WriteLine("Enter quantity:");
                        foodOrder.Quantity=Convert.ToInt32(Console.ReadLine());
                        
                        sb.Append($"\tQuantity::{foodOrder.Quantity}").AppendLine();
                        foodOrder.Price= orderService.PriceCalculation(foodOrder.FoodItem,foodOrder.Quantity);
                        cost.Add(foodOrder.Price);
                        sb.Append($"\tAmount::{foodOrder.Price}").AppendLine();
                        break;

                    case (int)MenuItemsChoices.Non_Vegetairan:
                        menuDisplay.NonVegDisplay();
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        foodOrder.FoodItem = Enum.GetName(typeof(NonVegetarian), ch1);
                        sb.Append(foodOrder.FoodItem).AppendLine();
                        Console.WriteLine("Enter quantity:");
                        foodOrder.Quantity = Convert.ToInt32(Console.ReadLine());
                        sb.Append($"\tQuantity::{foodOrder.Quantity}").AppendLine();
                        foodOrder.Price = orderService.PriceCalculation(foodOrder.FoodItem,foodOrder.Quantity);
                        cost.Add(foodOrder.Price);
                        sb.Append($"\tAmount::{foodOrder.Price}").AppendLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        continue;
                }
                Console.WriteLine("Do you want Order anything else:");
                string choi = Console.ReadLine();
                if (choi == "yes")
                    continue;
                else
                {
                    foodOrder.Price=orderService.TotalPriceCalculation(cost);
                    orderService.BillGeneration(foodOrder.CustomerName, sb.ToString(), foodOrder.Price);
                    break;
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
