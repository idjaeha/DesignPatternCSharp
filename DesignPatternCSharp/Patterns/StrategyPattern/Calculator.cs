using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StrategyPattern
{
    class Calculator
    {
        private IDiscountStrategy discountStrategy;

        public Calculator(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public int Calculate(List<Item> items)
        {
            int sum = 0;
            foreach (Item item in items)
            {
                sum += discountStrategy.GetDiscountPrice(item);
            }
            return sum;
        }
    }
}
