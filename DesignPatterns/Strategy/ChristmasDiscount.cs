namespace Strategy
{
    public class ChristmasDiscount : IDiscount
    {
        public decimal MakeDiscount(decimal price)
        {
            PurchaseValidations.MinPurchasePriceDiscountValidation(price);

            decimal discountPercentage = 0.95m;
            return price * discountPercentage;
        }
    }
}
