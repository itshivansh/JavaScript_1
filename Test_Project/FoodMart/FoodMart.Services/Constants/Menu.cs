namespace FoodMart.Services.Constants
{
    public class Menu
    {
        #region MenuItems Enumeration
        public enum MenuItemsChoices
        {
            Vegetarian=1,
            Non_Vegetairan,
        }
        #endregion

        #region Vegetarian Food Enumeration
        public enum Vegetarian
        {
            VegBiryani=1,
            MasalaDosa,
            Idli,
            Pulav
        }
        #endregion

        #region NonVegetarian Food Enumeration
        public enum NonVegetarian
        {
            ChickhenBiryani=1,
            Kabab,
            FishCurry,
            FishBiryani
        }
        #endregion
    }
}
