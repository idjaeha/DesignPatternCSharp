using DesignPatternCSharp.Patterns.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace DesignPatternCSharp.Patterns.Strategy
{
    class Strategy : IPattern
    {
        private IDiscountStrategy discountStrategy;
        private List<Item> items;
        private const int itemsSize = 10;

        private List<Item> CreateItems()
        {
            List<Item> newItems = new List<Item>();

            for(int idx = 0; idx < itemsSize; idx++)
            {
                newItems.Add(new Item() { Price = 1000 });
            }

            return newItems;
        }

        public void Start()
        {
            discountStrategy = new FirstGuestDiscountStrategy();
            Calculator calculator = new Calculator(discountStrategy);
            
            items = CreateItems();
            Console.WriteLine(calculator.Calculate(items));
        }
    }
}
