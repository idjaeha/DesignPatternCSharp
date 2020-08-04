using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.StatePattern
{
    class People
    {
        private IPeopleState state;

        public IPeopleState State
        {
            set
            {
                this.state = value;
            }
        }

        public People(IPeopleState state)
        {
            this.state = state;
        }

        public void SayHello()
        {
            state.Response();
        }
    }
}
