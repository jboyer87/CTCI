using System;
using CTCI.DataStructures;

namespace CTCI.Questions.Chapter02
{
	// Implement an algorithm to find the nth to last element of a singly-linked list.

	// A naive approach to this problem that came to mind first was to run through the list
	// once and count all of the elements. Armed with this information, I could iterate 
	// through the list again until I have moved total minus n times and return that 
	// element. This approach is a little slow because I have to run through the list twice.
	//
	// The second approach I came up with is to maintain two iterators. The first could be
	// advanced n times to start. Then I would have a gap between the two iterators equal to
	// n. This means that I could then advance each iterator one step at a time until the
	// forward iterator reached the end of the list. The second iterator would then be on
	// the element I would need to return. This feels like a better approach that the first.
	public class Question02<T>
	{
		public static Node<T> GetNthToLastElement(DataStructures.LinkedList<T> linkedList, 
			int n)
		{
			Node<T> forwardIterator = linkedList.Head;
			Node<T> backIterator = linkedList.Head;

			// Advance n times to create an n-sized gap between the iterators
			for(int i = 0; i < n; i++)
			{
				forwardIterator = forwardIterator.Next;
				
				// We hit the end of the list - there aren't enough elements to return the
				// nth from the last element
				if(forwardIterator == null)
				{
					throw new ArgumentException(
						String.Format("End of list encountered - cannot return the " +
						"element at index {0} - list does not have enough elements.", n)
					);
				}
			}

			while(forwardIterator != null)
			{
				forwardIterator = forwardIterator.Next;
				backIterator = backIterator.Next;
			}

			return backIterator;
		}
	}
}
