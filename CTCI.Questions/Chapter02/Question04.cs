using System;
using System.Collections.Generic;
using System.Text;

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
			// Placeholder
			return new DataStructures.LinkedList<int>();
		}
	}
}
