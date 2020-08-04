using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ProxyPattern
{
    class Proxy : IPattern
    {
        public void Start()
        {
            ArrayLoader arrayLoader = new ArrayLoader();
            arrayLoader.AddValue(new RealValue());
            arrayLoader.AddValue(new RealValue());
            arrayLoader.AddValue(new RealValue());
            arrayLoader.AddValue(new RealValue());
            arrayLoader.AddValue(new RealValue());
            arrayLoader.AddValue(new ProxyValue());
            arrayLoader.AddValue(new ProxyValue());
            arrayLoader.AddValue(new ProxyValue());
            arrayLoader.AddValue(new ProxyValue());
            arrayLoader.AddValue(new ProxyValue());
            arrayLoader.Load();
            Console.WriteLine("\n다시 불러오는 중입니다.\n");
            arrayLoader.Load();
        }
    }
}
