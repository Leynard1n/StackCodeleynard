using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCodeleynard.Code
{
    public class linkedStack<T>
    {
        public Item<T> Root { get; set; }
        public Item<T> Head { get; set; }
        public int Count { get; set; }
        

        public linkedStack() 
        {
            Root = null;
            Head = null;
            Count = 0;
        }

        public linkedStack(T data) 
        {
            Head = new Item<T>(data);
            Count = 1;
        }
        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previuos = Head;
            Head = item;
            Count ++;
        }
        public T Pop()
        {
             if (Count > 0) 
             {
                    var item = Head;
                Head = Head?.Previuos;
                Count--;
                return item.Data;
             }
            else { throw new NullReferenceException("Стек Пустует"); }
        }
        public T Peek()
        {
            if (Count > 0)
            { return Head.Data; }
            else { throw new NullReferenceException("Стек Пустует"); }
        }
    }
}
