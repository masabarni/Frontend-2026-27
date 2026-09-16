using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Framework
{
    internal abstract class Factory
    {
        public IProduct Create(string owner)
        {
            IProduct product =  CreateProduct(owner);

            return product;
        }

        public abstract IProduct CreateProduct(string owner);
    }
}
