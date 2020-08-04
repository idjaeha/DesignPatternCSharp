using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ObserverPattern
{
    class InputConsoleSender : IInputObserver
    {
        public void OnInput()
        {
            Console.WriteLine("키 입력이 감지되었습니다.");
        }

        public void OnInput(Status status)
        {
            Console.WriteLine("{0}키가 입력되었습니다.", status.KeyInfo.Key);
            Console.WriteLine("총 {0}번 입력되었습니다.\n", status.Count);
        }
    }
}
