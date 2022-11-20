using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class PlatinumDebitCard : DebitCard
    {
        public override string GetCardType()
        {
            return "Platinum Plus";
        }
        public override int GetCreditLimit()
        {
            return 35000;
        }
        public override int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
