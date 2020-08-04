using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.DecoratorPattern
{
    class Kimbob : IIngredient
    {
        public void Make()
        {
            Console.WriteLine("김밥 완성!");
        }
    }
}
