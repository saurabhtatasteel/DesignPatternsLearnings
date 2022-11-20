using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Template
{
    public class TemplateMethodClient
    {

        public void Test()
        {
            HouseBuilderTemplate houseBuilderTemplate = new ConcreteHouseBuilder();
            houseBuilderTemplate.Build();


            houseBuilderTemplate = new WoodenHouseBuilder();
            houseBuilderTemplate.Build();
        }
    }
}
