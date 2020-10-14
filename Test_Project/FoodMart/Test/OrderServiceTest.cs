using FoodMart.Services.Models;
using FoodMart.Services.Service;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    public class OrderServiceTest
    {
        OrderService service = new OrderService();
        FoodOrder foodOrder;
  

        [Test]
        public void Should_CalculatePrice_ReturnCost_ForVegBiryani()
        {
            foodOrder = new FoodOrder()
            {
                CustomerName = "Shivansh",
                FoodItem = "VegBiryani",
                Price = 150,
                Quantity = 2
            };
            var expectedValue = 300;
            var cost = service.PriceCalculation(foodOrder.FoodItem, foodOrder.Quantity);
            Assert.AreEqual(expectedValue, cost);
        }

        [TestCase(ExpectedResult =160)]
        public double Should_CalculatePrice_ReturnCost_ForFishCurry()
        {
            foodOrder = new FoodOrder()
            {
                CustomerName = "Vivek",
                FoodItem = "FishCurry",
                Price = 160,
                Quantity=1
            };
            var cost = service.PriceCalculation(foodOrder.FoodItem,foodOrder.Quantity);
            return cost;
        }

        [Test]
        public void Should_CalculateTotalPrice()
        {
            foodOrder = new FoodOrder()
            {
                CustomerName = "Hema",
                FoodItem = "Kabab",
                Price = 90,
                Quantity=3
            };
            var cost1 = service.PriceCalculation(foodOrder.FoodItem,foodOrder.Quantity);
            foodOrder = new FoodOrder()
            {
                CustomerName = "Hema",
                FoodItem = "ChickhenBiryani",
                Price = 165,
                Quantity=2
            };
            var cost2 = service.PriceCalculation(foodOrder.FoodItem,foodOrder.Quantity);
            var expectedValue = cost1 + cost2;
            List<double> list = new List<double>();
            list.Add(cost1);
            list.Add(cost2);
            cost2 = service.TotalPriceCalculation(list);
            Assert.AreEqual(cost2, expectedValue);
        }

    }
}

