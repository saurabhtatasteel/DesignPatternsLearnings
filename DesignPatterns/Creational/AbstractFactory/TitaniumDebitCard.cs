using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class TitaniumDebitCard : DebitCard
    {
        public override string GetCardType()
        {
            return "Titanium Edge";
        }
        public override int GetCreditLimit()
        {
            return 25000;
        }
        public override int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
