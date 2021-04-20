using System;
using System.Collections.Generic;

namespace Observer
{
    public class Bank : IBank
    {
        private readonly ICollection<IClient> _clients;
        private decimal _tax;

        public Bank()
        {
            this._clients = new HashSet<IClient>();
            this._tax = 10;
        }

        public decimal Tax => this._tax;

        public void Attach(IClient client)
        {
            this._clients.Add(client);

            Console.WriteLine("The client was attached!");
        }

        public void Detach(IClient client)
        {
            this._clients.Remove(client);

            Console.WriteLine("The client was detached!");
        }

        public void IncreaseTax(decimal amount)
        {
            this._tax += amount;

            this.Notify(amount);
        }

        private void Notify(decimal amount)
        {
            foreach (var client in this._clients)
            {
                client.Update(this, amount);
            }
        }
    }
}
