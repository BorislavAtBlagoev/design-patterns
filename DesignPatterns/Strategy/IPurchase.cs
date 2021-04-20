namespace Strategy
{
    public interface IPurchase
    {
        void SetDiscount(IDiscount discount);

        void PayPurchase();
    }
}
