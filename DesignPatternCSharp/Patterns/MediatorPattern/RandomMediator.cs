using System;
using System.Collections.Generic;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class RandomMediator : ItemSenderMediator
    {
        public RandomMediator(ItemList itemList, UserList userList) : base(itemList, userList)
        {

        }
        public override void SendItem()
        {
            int randomItemIndex = new Random().Next(0, itemList.GetCount() - 1);
            int randomUserIndex = new Random().Next(0, userList.GetCount() - 1);
            Item item = itemList.GetItem(randomItemIndex);
            User user = userList.GetUser(randomUserIndex);

            sender.SendItem(item.Name, user.Name);
        }
    }
}