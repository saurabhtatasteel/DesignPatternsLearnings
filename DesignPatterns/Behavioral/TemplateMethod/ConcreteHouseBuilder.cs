using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Template
{
    public class ConcreteHouseBuilder : HouseBuilderTemplate
    {
        public override void MakeFoundation()
        {
            Console.WriteLine("Concrete House Foundation done");
        }

        public override void MakePillars()
        {
            Console.WriteLine("Concrete House Pillars done");
        }
        public override void MakeWalls()
        {
            Console.WriteLine("Concrete House Walls done");
        }
    }
}
