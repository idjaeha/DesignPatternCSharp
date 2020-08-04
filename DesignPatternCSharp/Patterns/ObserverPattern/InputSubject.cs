using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ObserverPattern
{
    abstract class InputSubject
    {
        protected List<IInputObserver> inputObservers;


        public InputSubject()
        {
            inputObservers = new List<IInputObserver>();
        }

        public void Add(IInputObserver inputObserver)
        {
            inputObservers.Add(inputObserver);
        }

        public bool Remove(IInputObserver inputObserver)
        {
            return inputObservers.Remove(inputObserver);
        }

        public virtual void NotifyInput(ConsoleKeyInfo keyInfo)
        {
            foreach(IInputObserver inputObserver in inputObservers)
            {
                inputObserver.OnInput();
            }
        }
    }
}
