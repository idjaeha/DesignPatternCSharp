using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ObserverPattern
{
    /// <summary>
    /// 키 입력이 발동되면 주제 객체에게 그 사실을 전달한다.
    /// 주제 객체는 옵저버에게 그 사실을 전달해 콘솔창에 메세지를 띄운다.
    /// </summary>
    class Observer : IPattern
    {
        private bool isRunning = false;
        public void Start()
        {
            isRunning = true;
            while(isRunning)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch(keyInfo.Key)
                {
                    case ConsoleKey.Escape:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("{0}를 입력하셨습니다.", keyInfo.Key);
                        break;
                }
            }
        }
    }
}
