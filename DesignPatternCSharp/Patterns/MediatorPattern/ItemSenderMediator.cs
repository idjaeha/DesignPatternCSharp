using System.Collections.Generic;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public abstract class ItemSenderMediator
    {
        protected List<Item> items;
        protected List<User> users;
        protected ItemSenderMediator()
        {
            items = new List<Item>();
            users = new List<User>();
        }
        public abstract void SendItem();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}