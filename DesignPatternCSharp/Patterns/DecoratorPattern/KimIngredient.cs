using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.DecoratorPattern
{
    class KimIngredient : KimbobDecorator
    {
        public KimIngredient(IIngredient delegateIngredient) : base(delegateIngredient)
        {

        }

        public override void Make()
        {
            Console.WriteLine("김을 올리다.");
            doDelegate();
        }
    }
}
