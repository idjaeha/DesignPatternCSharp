using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.DecoratorPattern
{
    class RiceIngredient : KimbobDecorator
    {
        public RiceIngredient(IIngredient delegateIngredient) : base(delegateIngredient)
        {

        }

        public override void Make()
        {
            Console.WriteLine("밥을 올리다.");
            doDelegate();
        }
    }
}
