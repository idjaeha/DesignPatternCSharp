using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.DesignPattern.DecoratorPattern;
using DesignPatternCSharp.Patterns;
using DesignPatternCSharp.Patterns.ProxyPattern;

namespace ConsoleApp1.DesignPattern
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
