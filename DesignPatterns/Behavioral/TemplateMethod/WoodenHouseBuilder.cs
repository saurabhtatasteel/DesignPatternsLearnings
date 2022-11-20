using System;

namespace DesignPatterns.Structural.Template
{
	public class WoodenHouseBuilder : HouseBuilderTemplate
    {
        public override void MakeFoundation()
        {
            Console.WriteLine("Wooden House Foundation done");
        }

        public override void MakePillars()
        {
            Console.WriteLine("Wooden House Pillars done");
        }
        public override void MakeWalls()
        {
            Console.WriteLine("Wooden House Walls done");
        }
    }
}
