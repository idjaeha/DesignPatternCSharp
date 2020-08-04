using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ProxyPattern
{
    class RealValue : ICustomValue
    {
        public int Value { get; set; }

        public RealValue()
        {
            Value = new Random().Next(1, 10);
        }

        public void DisplayValue()
        {
            Console.WriteLine("값은 {0} 입니다.", Value);
        }
    }
}
