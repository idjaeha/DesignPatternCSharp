using System.Collections.Generic;

namespace DesignPatternCSharp.Patterns.MediatorPattern
{
    public class UserList
    {
        protected List<User> users;
        public UserList()
        {
            users = new List<User>();
        }

        public void Add(User user)
        {
            users.Add(user);
        }

        public User GetUser(int index)
        {
            return users[index];
        }

        public int GetCount()
        {
            return users.Count;
        }
    }
}