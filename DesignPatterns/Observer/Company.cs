using System;

namespace Observer
{
    public class Company : IClient
    {
        public void Update(IBank bank, decimal amount)
        {
            decimal maxTax = 20;

            if ((bank as Bank).Tax > maxTax)
            {
                Console.WriteLine($"The tax was increased with {amount}!");
            }
        }
    }
}
