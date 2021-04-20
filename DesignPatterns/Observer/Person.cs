using System;

namespace Observer
{
    public class Person : IClient
    {
        public void Update(IBank bank, decimal amount)
        {
            decimal maxTax = 10;

            if ((bank as Bank).Tax > maxTax)
            {
                Console.WriteLine($"The tax was increased with {amount}!");
            }
        }
    }
}
