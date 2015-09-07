using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Stack
{
    public class Stack
    {
        private readonly List<object> stackObject;

        public Stack()
        {
            stackObject = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj != null)
            {
                stackObject.Add(obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Pop()
        {
            var itemCount = stackObject.Count;
            if (itemCount == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                var lastItem = stackObject[itemCount - 1];
                stackObject.RemoveAt(itemCount - 1);
                return lastItem;
            }
        }

        public void Clear()
        {
            stackObject.Clear();
        }
    }
}
