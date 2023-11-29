using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCodeleynard.Code
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Previuos { get; set; }

        public Item(T data)
        {
            Data = data;

        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
} 

