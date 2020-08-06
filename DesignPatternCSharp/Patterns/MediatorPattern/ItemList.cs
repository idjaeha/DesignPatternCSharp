using System.Collections.Generic;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class ItemList
    {
        protected List<Item> items;
        public ItemList()
        {
            items = new List<Item>();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public Item GetItem(int index)
        {
            return items[index];
        }

        public int GetCount()
        {
            return items.Count;
        }
    }
}