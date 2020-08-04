using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StrategyPattern
{
    class FirstGuestDiscountStrategy : IDiscountStrategy
    {
        private const double discount = 0.9;
        public int GetDiscountPrice(Item item)
        {
            return (int)(item.Price * discount);
        }
    }
}
