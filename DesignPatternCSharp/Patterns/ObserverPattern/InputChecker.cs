using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ObserverPattern
{
    class InputChecker : InputSubject
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public override void NotifyInput(ConsoleKeyInfo keyInfo)
        {
            Count++;
            foreach (IInputObserver inputObserver in inputObservers)
            {
                inputObserver.OnInput(new Status() { Count = Count, KeyInfo = keyInfo });
            }
        }
    }
}
