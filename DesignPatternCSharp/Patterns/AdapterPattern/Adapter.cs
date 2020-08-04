using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.AdapterPattern
{
    class Adapter : IPattern
    {
        public void Start()
        {
            User user = new User();
            user.AddWeapon(new Sword());
            user.AddWeapon(new Sword());
            user.AddWeapon(new Sword());
            user.AddWeapon(new WeaponMagicBookAdapter());
            user.AddWeapon(new WeaponMagicBookAdapter());
            user.AddWeapon(new WeaponMagicBookAdapter());

            user.Action();
        }
    }
}
