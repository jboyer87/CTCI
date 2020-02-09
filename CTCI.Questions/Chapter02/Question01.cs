using System.Collections.Generic;
using CTCI.DataStructures;

namespace CTCI.Questions.Chapter02
{
	// Write code to remove duplicates from an unsorted linked list.
	public class Question01<T>
	{
		public static void RemoveDuplicates(DataStructures.LinkedList<T> linkedList)
		{
			if(linkedList.Head == null)
			{
				return;
			}

			var seen = new Dictionary<T, bool>();

			seen.Add(linkedList.Head.Value, true);

			Node<T> iterator = linkedList.Head;

			Node<T> previous = null;

			while(iterator.Next != null)
			{
				previous = iterator;
				iterator = iterator.Next;

				if(seen.ContainsKey(iterator.Value))
				{
					previous.Next = iterator.Next;
				}
				else
				{
					seen.Add(iterator.Value, true);
				}
			}
		}

	}
}
