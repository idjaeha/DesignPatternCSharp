using System;
using System.Collections.Generic;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class SequentialMediator : ItemSenderMediator
    {
        private int nextUserIndex;
        public SequentialMediator(ItemList itemList, UserList userList) : base(itemList, userList)
        {
            nextUserIndex = 0;
        }

        public override void SendItem()
        {
            int randomItemIndex = new Random().Next();
            Item item = itemList.GetItem(randomItemIndex);
            User user = userList.GetUser(nextUserIndex);

            sender.SendItem(item.Name, user.Name);
            nextUserIndex = (nextUserIndex + 1) % userList.GetCount();
        }
    }
}