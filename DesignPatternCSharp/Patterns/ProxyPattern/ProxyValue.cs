using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ProxyPattern
{
    class ProxyValue : ICustomValue
    {
        private RealValue realValue;

        public void DisplayValue()
        {
            if(realValue == null)
            {
                realValue = new RealValue();
                Console.WriteLine("값을 읽어 오는 중입니다.");
                return;
            }
            realValue.DisplayValue();
        }
    }
}
