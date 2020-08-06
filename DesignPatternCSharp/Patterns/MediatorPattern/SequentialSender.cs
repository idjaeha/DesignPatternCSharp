using System;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class SequentialSender : ItemSenderMediator
    {
        private int nextIndex;

        public SequentialSender() : base()
        {
            nextIndex = 0;
        }

        public override void SendItem()
        {
            int randomItemIndex = new Random().Next(0, items.Count - 1);
            Console.WriteLine("{0}에게 {1}을 지급했습니다.",
            users[nextIndex].Name,
            items[randomItemIndex].Name);
            nextIndex = (nextIndex + 1) % items.Count;
        }
    }
}