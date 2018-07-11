using System.Collections.Generic;

namespace CTCI.Questions.Chapter01
{
	public class Question01
	{
		// Implement an algorithm to determine if a string has all unique characters.

		// I decided first to use a hash set, because a hashset does not allow duplicate
		// values. The hash function is used to be able to find a character in the string
		// without iterating through a list or other similar data structure. I then add
		// each character in the string to the hash set and monitor the count of to see if
		// it has increased. If it has, this means we have added a unique character, and
		// should continue checking the string. If the count does not increase, we have
		// found a duplicate and should return false.

		// Time complexity is O(n), space complexity is O(n)
		public static bool HasUniqueCharacters(string s)
		{
			HashSet<char> characterSet = new HashSet<char>();

			foreach (char c in s)
			{
				int countBefore = characterSet.Count;

				characterSet.Add(c);

				if (countBefore == characterSet.Count)
				{
					return false;
				}
			}

			return true;
		}

		// ...What if you cannot use additional data structures?

		// If you cannot use additional data structures, using an array of true/false 
		// values can work. If you know the number of characters in your character set
		// (0-255 for ascii for example) you can use a fixed size array. Check each char
		// and flip from false --> true when a character is found. If a value is already
		// true when it is visited, you have found a duplicate value.
		// This method turns out to be much faster than the first method. It is easy to 
		// see why. We are not running a hashing algorithm against every value. The fixed
		// size array will also never have to change in size. Most data structures double
		// in size once the maximum capacity has been reached. We will not have this 
		// overhead with an array.
		// Note: This is the solution in the book, implemented in C# instead of Java.

		// Time complexity is O(n), space complexity is O(n)
		public static bool HasUniqueCharacters2(string s)
		{
			bool[] characterSet = new bool[256];

			foreach (char c in s)
			{
				if (characterSet[(int)c])
				{
					return false;
				}
				else
				{
					characterSet[(int)c] = true;
				}
			}

			return true;
		}
	}
}