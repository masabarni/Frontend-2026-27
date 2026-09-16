using Factory.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Framework;

namespace Factory.CreditCard
{
    internal class CreditCard : IProduct
    {
        private readonly string owner;

        public CreditCard(string owner)
        {
            this.owner = owner;
            Console.WriteLine($"Make {this.owner}'s card.");
        }

        public void Use()
        {
            Console.WriteLine($"Use{this.owner}'s card");
        }
    }
}
