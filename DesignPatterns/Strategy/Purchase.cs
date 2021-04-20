using System;

namespace Strategy
{
    public class Purchase : IPurchase
    {
        private decimal _price;
        private IDiscount _dicount;

        public Purchase(decimal price)
        {
            this._price = price;
        }

        public void SetDiscount(IDiscount discount)
        {
            this._dicount = discount;
        }

        public void PayPurchase()
        {
            Console.WriteLine($"Your purchase price: {this._price} BGN");

            if (this._dicount != null)
            {
                decimal priceAfterDiscount = this._dicount.MakeDiscount(this._price);
                Console.WriteLine($"Your purchase price after discount: {priceAfterDiscount} BGN");
            }

            Console.WriteLine($"Your purchase was payed!");
        }
    }
}
