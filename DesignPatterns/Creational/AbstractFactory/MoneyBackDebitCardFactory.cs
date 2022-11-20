﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MoneyBackDebitCardFactory : DebitCardFactory
    {
        protected override DebitCard MakeProduct()
        {
            DebitCard product = new MoneyBackDebitCard();
            return product;
        }
    }
}
