using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class DebitCard : ICard
    {
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
        public abstract int GetAnnualCharge();
    }
}
