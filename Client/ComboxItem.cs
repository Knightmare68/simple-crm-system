using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public class ComboxItem
    {
        private string name;
        private object value;
        public string Name { get { return name; } }
        public object Value { get { return this.value; } }
        public ComboxItem(string name, object value)
        {
            this.name = name; this.value = value;
        }
    }
}
