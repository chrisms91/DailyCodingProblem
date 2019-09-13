using Ctci.Ch03.StacksandQueues.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_03._Stacks_and_Queues
{
	public class MyQueue<T>
	{
		protected class QueueNode
		{
			protected T data;
			protected QueueNode next;

			public QueueNode(T data)
			{
				this.data = data;
			}

			private QueueNode first;
			private QueueNode last;

			public void Add(T item)
			{
				QueueNode q = new QueueNode(item);

				if (first == null)
				{
					first = q;
				}

				if (last != null)
				{
					last.next = q;
				}

				last = q;
			}

			public T Remove()
			{
				if (first == null)
				{
					throw new EmptyQueueException(nameof(Remove));
				}

				var item = first.data;
				first = first.next;
				if (first == null)
				{
					last = null;
				}
				return item;
			}

			public T Peek()
			{
				if (first == null)
				{
					throw new EmptyQueueException(nameof(Peek));
				}
				return first.data;
			}

			public bool IsEmpty()
			{
				return first == null;
			}
		}
	}
}
