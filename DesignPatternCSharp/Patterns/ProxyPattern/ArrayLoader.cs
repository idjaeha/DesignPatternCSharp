using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Patterns.ProxyPattern
{
    class ArrayLoader
    {
        private List<ICustomValue> customValues;

        public ArrayLoader()
        {
            customValues = new List<ICustomValue>();
        }

        public void AddValue(ICustomValue customValue)
        {
            customValues.Add(customValue);
        }

        public void Load()
        {
            foreach(ICustomValue customValue in customValues)
            {
                customValue.DisplayValue();
            }
        }
    }
}
