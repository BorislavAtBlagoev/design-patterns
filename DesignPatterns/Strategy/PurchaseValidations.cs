using System;

namespace Strategy
{
    public static class PurchaseValidations
    {
        public static void MinPurchasePriceDiscountValidation(decimal priceForDiscount)
        {
            if (priceForDiscount < 100)
            {
                throw new Exception("Cannot make discount to purchase less than 100 BNG");
            }
        }
    }
}
