using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.DataStructures
{
	public class LinkedList<T>
	{
		public LinkedList()
		{
			Head = null;
		}

		public Node<T> Head { get; set; }

		public void AppendToTail(T value)
		{
			var node = new Node<T>(value);

			if (Head == null)
			{
				Head = node;
			}
			else
			{
				Node<T> iterator = Head;

				while (Head.Next != null)
				{
					iterator = Head.Next;
				}

				iterator.Next = node;
			}
		}

		public void DeleteNode(int index)
		{
			if (Head == null)
			{
				return;
			}

			int currentPosition = 1;

			Node<T> iterator = Head;

			while(Head.Next != null && currentPosition < index)
			{
				iterator = iterator.Next;
			}

			if(iterator.Next.Next == null)
			{
				return;
			}

			iterator.Next = iterator.Next.Next;
		}
	}
}
