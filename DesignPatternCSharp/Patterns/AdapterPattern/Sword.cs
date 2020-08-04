using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.AdapterPattern
{
    class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("검을 휘둘렀습니다.");
        }
    }
}
