namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class Mediator : IPattern
    {
        public void Start()
        {
            //ItemSenderMediator itemMediator = new SequentialMediator(new ItemList(), new UserList());
            ItemSenderMediator itemMediator = new RandomMediator(new ItemList(), new UserList());
            itemMediator.AddItem(new Item("활"));
            itemMediator.AddItem(new Item("검"));
            itemMediator.AddItem(new Item("총"));
            itemMediator.AddItem(new Item("창"));
            itemMediator.AddItem(new Item("도끼"));

            itemMediator.AddUser(new User("User1"));
            itemMediator.AddUser(new User("User2"));
            itemMediator.AddUser(new User("User3"));
            itemMediator.AddUser(new User("User4"));
            itemMediator.AddUser(new User("User5"));

            itemMediator.SendItem();
            itemMediator.SendItem();
            itemMediator.SendItem();
            itemMediator.SendItem();
            itemMediator.SendItem();
        }
    }
}