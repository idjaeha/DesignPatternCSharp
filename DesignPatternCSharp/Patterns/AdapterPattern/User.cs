using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.AdapterPattern
{
    class User
    {
        private List<IWeapon> weapons;

        public User()
        {
            weapons = new List<IWeapon>();
        }

        public void Action()
        {
            foreach(IWeapon weapon in weapons)
            {
                weapon.Attack();
            }
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.Add(weapon);
        }
    }
}
