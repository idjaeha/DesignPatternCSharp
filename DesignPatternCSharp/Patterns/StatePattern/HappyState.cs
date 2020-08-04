using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StatePattern
{
    class HappyState : IPeopleState
    {
        public void Response()
        {
            Console.WriteLine("Hello~~~ ^^");
        }
    }
}
