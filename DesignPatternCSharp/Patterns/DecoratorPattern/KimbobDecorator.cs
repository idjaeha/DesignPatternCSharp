using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.DecoratorPattern
{
    abstract class KimbobDecorator : IIngredient
    {
        private IIngredient delegateIngredient;

        public KimbobDecorator(IIngredient delegateIngredient)
        {
            this.delegateIngredient = delegateIngredient;
        }

        protected void doDelegate()
        {
            delegateIngredient.Make();
        }

        public abstract void Make();
    }
}
