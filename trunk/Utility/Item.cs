using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class Item
    {
        private string name;
        private object value;
        public string Name { get { return name; } }
        public object Value { get { return this.value; } }
        public Item(string name, object value)
        {
            this.name = name; this.value = value;
        }
    }
}
