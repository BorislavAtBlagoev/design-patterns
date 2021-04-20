namespace Strategy
{
    public class EasterDiscount : IDiscount
    {
        public decimal MakeDiscount(decimal price)
        {
            PurchaseValidations.MinPurchasePriceDiscountValidation(price);

            decimal discountPercentage = 0.97m;
            return price * discountPercentage;
        }
    }
}
