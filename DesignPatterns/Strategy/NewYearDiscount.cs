namespace Strategy
{
    public class NewYearDiscount : IDiscount
    {
        public decimal MakeDiscount(decimal price)
        {
            PurchaseValidations.MinPurchasePriceDiscountValidation(price);

            decimal discountPercentage = 0.99m;
            return price * discountPercentage;
        }
    }
}
