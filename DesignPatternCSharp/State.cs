using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DesignPattern
{
    interface IPeopleState
    {
        public void Response();
    }

    class AngryState : IPeopleState
    {
        public void Response()
        {
            Console.WriteLine("Go away!!!");
        }
    }

    class HappyState : IPeopleState
    {
        public void Response()
        {
            Console.WriteLine("Hello~~~ ^^");
        }
    }

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
