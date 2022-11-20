using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class DebitCardFactory
    {
        protected abstract DebitCard MakeProduct();

        public DebitCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
