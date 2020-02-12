using System;
using System.Collections.Generic;
using System.Text;
using CTCI.DataStructures;

namespace CTCI.Questions.Chapter02
{

	// You have two numbers represented by a linked list, where each node contains a single 
	// digit.The digits are stored in reverse order, such that the 1's digit is at the head 
	// of the list. Write a function that adds the two numbers and returns the sum as a 
	// linked list.

	// Essentially this method needs to look at each value and add them together, storing
	// the result of the calculation in a new node in a new list to be returned. The method
	// also needs to take care of carrying numbers over when the result is more than 9.
	public class Question04
	{
		public static DataStructures.LinkedList<int> AddLinkedLists(
			DataStructures.LinkedList<int> first, 
			DataStructures.LinkedList<int> second)
		{
			if(first.Head == null && second.Head == null)
			{
				return null;
			}

			var summedLists = new DataStructures.LinkedList<int>();
			var summedRunner = new DataStructures.Node<int>(0);

			summedLists.Head = summedRunner;

			DataStructures.Node<int> firstRunner = first.Head;
			DataStructures.Node<int> secondRunner = second.Head;
			
			bool carry = false;

			while (firstRunner != null || secondRunner != null)
			{
				var newNode = new DataStructures.Node<int>(0);

				int sum = 0;

				if(carry)
				{
					sum++;
				}

				if(firstRunner == null)
				{
					sum += secondRunner.Value;
				}
				else if(secondRunner == null)
				{
					sum += firstRunner.Value;
				}
				else
				{
					sum += firstRunner.Value + secondRunner.Value;
				}

				carry = false;

				if(sum >= 10)
				{
					sum -= 10;
					carry = true;
				}

				summedRunner.Value = sum;

				summedRunner.Next = newNode;
				summedRunner = summedRunner.Next;

				firstRunner = firstRunner == null ? null : firstRunner.Next ?? null;
				secondRunner = secondRunner == null ? null : secondRunner.Next ?? null;
			}

			return summedLists;
		}
	}
}
