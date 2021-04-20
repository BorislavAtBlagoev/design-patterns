using System;

namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            decimal purchasePrice = 1000;

            try
            {
                IPurchase purchase = new Purchase(purchasePrice);

                IDiscount christmasDiscount = new ChristmasDiscount();
                IDiscount easterDicount = new EasterDiscount();
                IDiscount newYearDiscount = new NewYearDiscount();

                purchase.SetDiscount(newYearDiscount);
                purchase.PayPurchase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
