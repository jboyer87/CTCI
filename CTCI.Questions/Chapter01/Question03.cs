using System;

namespace CTCI.Questions.Chapter01
{
	public class Question03
	{
		// Design an algorithm and write code to remove the duplicate characters in a 
		// string without using any additional buffer. NOTE: One or two additional
		// variables are fine. An extra copy of the array is not.

		// Similar to question 1, we need to determine when a character has been seen 
		// before. Assuming an ascii character set with 256 characters, we can use
		// another boolean array to keep track of which characters were seen. When we 
		// come across a duplicate character, we will remove it. This algorithm always
		// keeps the first instance of a character, and removes all subsequent instances
		// from left to right.

		// Time complexity is O(n), space complexity is O(n)
		// Note that the boolean array is of constant size, and to accommodate a larger
		// character set, we only need to change the size of the array.
		public static void RemoveDuplicateCharacters(ref string s)
		{
			if (s == null)
			{
				return;
			}

			bool[] charactersSeen = new bool[256];

			int currentIndex = 0;

			foreach (char c in s)
			{
				// If we have seen this character, remove it
				if (charactersSeen[(int)c])
				{
					s = s.Remove(currentIndex, 1);
					// We shortened the string, decrement the index
					currentIndex--;
				}
				// If we haven't, mark it as seen
				else
				{
					charactersSeen[(int)c] = true;
				}

				currentIndex++;
			}
		}
	}
}