using System;
namespace Ctci.Ch03.StacksandQueues.Exceptions
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException()
        {
        }

        public EmptyQueueException(string message)
            : base(message)
        {
        }

        public EmptyQueueException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
