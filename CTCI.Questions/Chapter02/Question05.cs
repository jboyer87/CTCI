using System;

namespace CTCI.Questions.Chapter02
{
	// Given a circular linked list, implement an algorithm which returns the node at the beginning
	// of the loop. A circular linked list is a linked list in which a node's next pointer points
	// to an earlier node, making a loop in the linked list.
	public class Question05
	{
		public static DataStructures.Node<T> GetNodeAtBeginningOfLoop<T>(
			DataStructures.LinkedList<T> linkedList)
		{
			if(linkedList.Head == null)
			{
				throw new ArgumentException("Cannot evaluate an empty list.");
			}

			DataStructures.Node<T> slowRunner = linkedList.Head;
			DataStructures.Node<T> fastRunner = linkedList.Head;


			while(true)
			{
				// Jump ahead one
				slowRunner = slowRunner.Next;

				if(fastRunner.Next != null)
				{
					// Jump ahead two
					fastRunner = fastRunner.Next.Next;
				}
				else
				{
					throw new ArgumentException("List does not have a loop.");
				}

				if(slowRunner == fastRunner)
				{
					return slowRunner;
				}
			}
		}
	}
}
