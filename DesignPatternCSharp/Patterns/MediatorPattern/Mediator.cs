namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class Mediator : IPattern
    {
        public void Start()
        {
            // ItemSenderMediator itemSender = new RandomSender();
            ItemSenderMediator itemSender = new SequentialSender();
            itemSender.AddItem(new Item("활"));
            itemSender.AddItem(new Item("검"));
            itemSender.AddItem(new Item("총"));
            itemSender.AddItem(new Item("창"));
            itemSender.AddItem(new Item("도끼"));

            itemSender.AddUser(new User("User1"));
            itemSender.AddUser(new User("User2"));
            itemSender.AddUser(new User("User3"));
            itemSender.AddUser(new User("User4"));
            itemSender.AddUser(new User("User5"));

            itemSender.SendItem();
            itemSender.SendItem();
            itemSender.SendItem();
            itemSender.SendItem();
            itemSender.SendItem();
        }
    }
}