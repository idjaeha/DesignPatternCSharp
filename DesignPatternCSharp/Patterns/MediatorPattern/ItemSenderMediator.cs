using System.Collections.Generic;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public abstract class ItemSenderMediator
    {
        protected readonly UserList userList;
        protected readonly ItemList itemList;
        protected Sender sender;
        protected ItemSenderMediator(ItemList itemList, UserList userList)
        {
            this.itemList = itemList;
            this.userList = userList;
            sender = new Sender();
        }
        public abstract void SendItem();

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }
    }
}