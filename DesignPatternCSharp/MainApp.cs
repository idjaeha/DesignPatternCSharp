using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternCSharp.Patterns;
using DesignPatternCSharp.Patterns.ProxyPattern;

namespace DesignPatternCSharp
{
    class MainApp
    {
        private static IPattern pattern;
        public static void Main(String[] args)
        {
            pattern = new Proxy();
            pattern.Start();
        }
    }
}
