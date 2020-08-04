using DesignPatternCSharp.Patterns;
using DesignPatternCSharp.Patterns.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DesignPattern.DecoratorPattern
{
    class Decorator : IPattern
    {
        public void Start()
        {
            IIngredient kimbob = new Kimbob();
            IIngredient makeKimbob = new KimIngredient(new RiceIngredient(kimbob));
            makeKimbob.Make();
        }
    }
}
