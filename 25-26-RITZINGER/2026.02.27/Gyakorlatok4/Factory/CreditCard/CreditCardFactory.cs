using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Framework;

namespace Factory.CreditCard
{
    internal class CreditCardFactory : Factory.Framework.Factory
    {
        public CreditCardFactory() 
        {
            
        }

        public override IProduct CreateProduct(string owner)
        {
            return new CreditCard(owner);
        }
    }
}
