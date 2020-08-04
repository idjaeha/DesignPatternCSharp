using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StatePattern
{
    class AngryState : IPeopleState
    {
        public void Response()
        {
            Console.WriteLine("Go away!!!");
        }
    }
}
