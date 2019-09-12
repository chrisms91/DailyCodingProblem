using System;
namespace Ctci.Ch03.StacksandQueues.Exceptions
{
    public class FullStackException : Exception
    {
        public FullStackException()
        {
        }

        public FullStackException(string message)
            : base(message)
        {
        }

        public FullStackException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}