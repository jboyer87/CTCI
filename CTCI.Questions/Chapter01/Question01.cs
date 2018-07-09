using System.Collections.Generic;

namespace CTCI.Questions.Chapter01
{
	public class Question01
	{
		// Implement an algorithm to determine if a string has all unique characters. What
		// if you cannot use additional data structures?

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
	}
}