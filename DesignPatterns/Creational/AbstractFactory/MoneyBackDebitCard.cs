﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MoneyBackDebitCard : DebitCard
    {
        public override string GetCardType()
        {
            return "MoneyBack";
        }
        public override int GetCreditLimit()
        {
            return 15000;
        }
        public override int GetAnnualCharge()
        {
            return 500;
        }
    }
}
