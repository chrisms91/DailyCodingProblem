using System;
namespace Ctci.Ch03.StacksandQueues.Exceptions
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
        }

        public EmptyStackException(string message)
            : base(message)
        {
        }

        public EmptyStackException(string message, Exception inner)
            :base(message, inner)
        {
        }
    }
}
