using System;
using System.Collections.Generic;

namespace FoodMart.Services.Service
{
    interface IOrderService
    {
        #region Declaration of Interface Methods
        double PriceCalculation(string foodName,int quantity);
        double TotalPriceCalculation(List<double> cost);
        void BillGeneration(String customerName,String name,double totalPrice);
        #endregion
    }
}
