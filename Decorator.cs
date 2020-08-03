using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DesignPattern
{
    interface IIngredient
    {
        public void Make();
    }
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

    class Kimbob : IIngredient
    {
        public void Make()
        {
            Console.WriteLine("김밥 완성!");
        }
    }

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
