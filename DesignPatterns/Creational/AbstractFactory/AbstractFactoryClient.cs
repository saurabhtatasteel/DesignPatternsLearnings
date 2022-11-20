using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryClient
    {

        public void TestClient()
        {
            var platinumDebitCard = new PlatinumDebitCardFactory().CreateProduct();
            if (platinumDebitCard != null)
            {
                Console.WriteLine("Card Type : " + platinumDebitCard.GetCardType());
                Console.WriteLine("Credit Limit : " + platinumDebitCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + platinumDebitCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            var moneybackDebitCard = new MoneyBackDebitCardFactory().CreateProduct();
            if (moneybackDebitCard != null)
            {
                Console.WriteLine("Card Type : " + moneybackDebitCard.GetCardType());
                Console.WriteLine("Credit Limit : " + moneybackDebitCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + moneybackDebitCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

        }

    }
}
