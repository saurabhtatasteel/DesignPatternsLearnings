using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Decorator
{
    /// <summary>
    /// This is base pizza
    /// </summary>
    public class BasePizza : IBasePizza
    {
        public float GetPrice()
        {
            return 2F;
        }
    }
}
