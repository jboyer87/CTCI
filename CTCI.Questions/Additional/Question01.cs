using System;
using System.Collections.Generic;

namespace CTCI.Questions.Additional
{
	// Given two sorted arrays, merge them together in a sorted manner.

	// The idea here was to essentially merge the two arrays together by comparing one item 
	// from each array at a time in order to provide O(n) time complexity. We compare one
	// item from each array and add the lower item to the new array. If one array runs out
	// of items first, we can assume that the rest of the items left in the other array are
	// all higher so we can fill the remaining slots with it.

	public class Question01
	{
		public static int[] MergeAndSort(int[] first, int[] second)
		{
			int sizeOfCombinedArray = first.Length + second.Length;

			int[] combined = new int[sizeOfCombinedArray];

			int i = 0;
			int j = 0;
			int currentPosition = 0;

			while (i < first.Length && j < first.Length)
			{
				if (first[i] <= second[j])
				{
					combined[currentPosition] = first[i];
					i++;
					currentPosition++;
				}
				else
				{
					combined[currentPosition] = second[j];
					j++;
					currentPosition++;
				}

				if (i == first.Length)
				{
					while (j < second.Length)
					{
						combined[currentPosition] = second[j];

						j++;
						currentPosition++;
					}
				}
				else if (j == second.Length)
				{
					while (i < first.Length)
					{
						combined[currentPosition] = second[i];

						i++;
						currentPosition++;
					}
				}
			}

			return combined;
		}
	}
}