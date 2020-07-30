using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace ConsoleApp1.DesignPattern
{
    class Item
    {
        public int Price { get; set; }
    }

    interface IDiscountStrategy
    {
        public int GetDiscountPrice(Item item);
    }

    class FirstGuestDiscountStrategy : IDiscountStrategy
    {
        private const double discount = 0.9;
        public int GetDiscountPrice(Item item)
        {
            return (int)(item.Price * discount);
        }
    }

    class NonFreshItemDiscountStrategy : IDiscountStrategy
    {
        private const double discount = 0.8;
        public int GetDiscountPrice(Item item)
        {
            return (int)(item.Price * discount);
        }
    }

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
            foreach(Item item in items)
            {
                sum += discountStrategy.GetDiscountPrice(item);
            }
            return sum;
        }
    }

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
