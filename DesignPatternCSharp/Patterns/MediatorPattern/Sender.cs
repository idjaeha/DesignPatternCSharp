using System;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class Sender
    {
        public void SendItem(string itemName, string userName)
        {
            Console.WriteLine("{0}에게 {1}을 지급했습니다.",
            itemName,
            userName);
        }
    }
}