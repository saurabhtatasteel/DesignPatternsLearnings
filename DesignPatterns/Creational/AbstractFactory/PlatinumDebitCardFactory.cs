using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class PlatinumDebitCardFactory : DebitCardFactory
    {
        protected override DebitCard MakeProduct()
        {
            DebitCard product = new PlatinumDebitCard();
            return product;
        }
    }
}
