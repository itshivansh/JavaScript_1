namespace FoodMart.Services.Models
{
   public class FoodOrder
    {
        #region Property Declaration 
        public string CustomerName { get; set; }
        public string FoodItem { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        #endregion

    }
}
