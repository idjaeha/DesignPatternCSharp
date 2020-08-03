using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DesignPattern
{
    interface IPattern
    {
        public void Start();
    }

    class MainApp
    {
        private static IPattern pattern;
        public static void Main(String[] args)
        {
            pattern = new TemplateDeformation();
            pattern.Start();
        }
    }
}
