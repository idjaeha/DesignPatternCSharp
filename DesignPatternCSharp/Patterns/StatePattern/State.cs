using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StatePattern
{
    class State : IPattern
    {
        public void Start()
        {
            People people = new People(new AngryState());
            people.SayHello();

            people.State = new HappyState();
            people.SayHello();
        }
    }
}
