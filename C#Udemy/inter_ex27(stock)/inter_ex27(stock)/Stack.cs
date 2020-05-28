using System;
using System.Collections.Generic;

namespace inter_ex27_stack_
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();
             
        public void Push(object obj)
        {
            if (obj != null)
                _stack.Add(obj);
            else
                Console.WriteLine("InvalidOperationException");
        }
        public object Pop()
        {
            if (_stack != null)
            {
                
                var n = _stack.Count;
                var obj = _stack[n - 1];
                _stack.RemoveAt(n - 1);
                return (obj);
            }
            else
                Console.WriteLine("InvalidOperationException");
            return (0);
        }
        public void Clear()
        {
            _stack.Clear();
        }
    }
}
