using System;

namespace CTCI.Questions.Chapter02
{
	// Implement an algorithm to delete a node in the middle of a singly-linked list, given
	// only access to that node.

	// If you only have access to a single node and need to delete it from a linked list,
	// you can copy the data from the next element into the current element and then delete
	// the next element instead. This is kind of a clever trick - you don't need to iterate
	// over the entire list (not that you had access to the HEAD element anyway...).
	public class Question03<T>
	{
		public static void RemoveNodeFromList(ref DataStructures.Node<T> node)
		{
			if(node.Next == null)
			{
				throw new ArgumentException("Cannot delete node using this method - next " +
					"element is null");
			}

			T nextNodeValue = node.Next.Value;

			node.Value = nextNodeValue;

			node.Next = node.Next.Next;
		}
	}
}
