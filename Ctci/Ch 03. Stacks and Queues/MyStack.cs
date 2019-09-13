using System;
using System.Threading;
using Ctci.Ch03.StacksandQueues.Exceptions;

namespace Ctci.Ch03.StacksandQueues
{
    public class MyStack<T>
    {
        protected class StackNode
        {
            public T data;
            public StackNode next;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode top;

        public T Pop()
        {
            if (top == null)
                throw new EmptyStackException(nameof(Pop));

            var item = top.data;
            top = top.next;
            return item;
        }

        public void Push(T item)
        {
            var t = new StackNode(item);
            t.next = top;
            top = t;
        }

        public T Peek()
        {
            if (top == null)
                throw new EmptyStackException(nameof(Peek));
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
