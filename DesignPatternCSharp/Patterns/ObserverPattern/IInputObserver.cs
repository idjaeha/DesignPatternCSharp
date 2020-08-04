using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ObserverPattern
{
    interface IInputObserver
    {
        void OnInput();
        void OnInput(Status status);
    }
}
