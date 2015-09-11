using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Stack
{
    public class Stack
    {
        private readonly List<object> _objects;

        public Stack()
        {
            _objects = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }

            _objects.Add(obj);
        }

        public object Pop()
        {
            if (_objects.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var lastItem = _objects[_objects.Count - 1];
            _objects.RemoveAt(_objects.Count - 1);
            return lastItem;
        }

        public void Clear()
        {
            _objects.Clear();
        }
    }
}
