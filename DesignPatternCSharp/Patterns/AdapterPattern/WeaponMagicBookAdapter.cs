using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.AdapterPattern
{
    class WeaponMagicBookAdapter : IWeapon
    {
        MagicBook magicBook;

        public WeaponMagicBookAdapter()
        {
            magicBook = new MagicBook();
        }

        public void Attack()
        {
            magicBook.Cast();
        }
    }
}
