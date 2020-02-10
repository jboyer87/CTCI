using System.Collections.Generic;
using CTCI.DataStructures;

namespace CTCI.Questions.Chapter02
{
	// Write code to remove duplicates from an unsorted linked list.

	// A naive approach to this problem might be to iterate over the list once while keeping
	// track of all of the duplicates and then iterating over it a second time to clean them
	// all up. A better solution might be to keep track of which elements we have seen
	// before while iterating over the list and then removing any duplicates as we see them.
	// We can use a dictionary to quickly check whether or not we have seen an element
	// before.

	// A follow-up to this question asks: How would you solve this problem if a temporary
	// buffer is not allowed?

	// Removing the temporary buffer makes the question a little trickier. If the idea is to
	// favor space-efficiency over time-efficiency, we could use two iterators. The first
	// would traverse the list one-by-one, giving a pointer to the current element we're
	// checking. The second would traverse the remaining elements of the list, looking for
	// dupes matching the first iterator and removing them along the way.

	public class Question01<T>
	{
		public static void RemoveDuplicates(DataStructures.LinkedList<T> linkedList)
		{
			if (linkedList.Head == null)
			{
				return;
			}

			var seen = new Dictionary<T, bool>();

			seen.Add(linkedList.Head.Value, true);

			Node<T> iterator = linkedList.Head;

			while (iterator.Next != null)
			{
				Node<T> previous = iterator;
				iterator = iterator.Next;

				if (seen.ContainsKey(iterator.Value))
				{
					previous.Next = iterator.Next;
				}
				else
				{
					seen.Add(iterator.Value, true);
				}
			}
		}

		public static void RemoveDuplicatesNoBuffer(DataStructures.LinkedList<T> linkedList)
		{
			if (linkedList.Head == null)
			{
				return;
			}

			Node<T> backIterator = linkedList.Head;

			while (backIterator != null)
			{
				Node<T> forwardIterator = backIterator.Next;
				Node<T> previousNode = backIterator;

				while (forwardIterator != null)
				{
					// If we have found a dupe, remove it from the list.
					if (forwardIterator.Value.Equals(backIterator.Value))
					{
						previousNode.Next = forwardIterator.Next;
					}

					previousNode = previousNode.Next;
					forwardIterator = forwardIterator.Next;
				}

				backIterator = backIterator.Next;
			}
		}
	}
}
