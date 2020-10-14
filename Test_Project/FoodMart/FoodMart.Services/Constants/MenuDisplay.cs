using System;
using static FoodMart.Services.Constants.Menu;

namespace FoodMart.Services.Constants
{
    public class MenuDisplay
    {
        #region Menu item displaying
        public void MenuItemDisplay()
        {
            foreach (int menuOrder in Enum.GetValues(typeof(MenuItemsChoices)))
            {
                Console.WriteLine($"For {Enum.GetName(typeof(MenuItemsChoices), menuOrder)} enter {menuOrder}");
            }
        }
        #endregion

        #region Veg Food Menu
        public void VegFoodDisplay()
        {
            foreach (int vegFood in Enum.GetValues(typeof(Vegetarian)))
            {
                Console.WriteLine($"For {Enum.GetName(typeof(Vegetarian), vegFood)} enter {vegFood}");
            }
        }
        #endregion

        #region NonVeg Food Menu
        public void NonVegDisplay()
        {
            foreach (int nonVeg in Enum.GetValues(typeof(NonVegetarian)))
            {
                Console.WriteLine($"For {Enum.GetName(typeof(NonVegetarian), nonVeg)} enter {nonVeg}");
            }
        }
        #endregion
    }
}
