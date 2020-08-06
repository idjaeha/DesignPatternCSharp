using System;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class RandomSender : ItemSenderMediator
    {
        public override void SendItem()
        {
            int randomUserIndex = new Random().Next(0, users.Count - 1);
            int randomItemIndex = new Random().Next(0, items.Count - 1);
            Console.WriteLine("{0}에게 {1}을 지급했습니다.",
            users[randomUserIndex].Name,
            items[randomItemIndex].Name);
        }
    }
}