using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StrategyPattern
{
    interface IDiscountStrategy
    {
        public int GetDiscountPrice(Item item);
    }
}
