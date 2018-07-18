using System;
using System.Collections.Generic;

namespace CTCI.Questions.Chapter01
{
	public static class ExtensionMethods
	{
		public static string Sort(this string s)
		{
			var charArray = s.ToCharArray();

			Array.Sort(charArray);

			return charArray.ToString();
		}
	}
	public class Question04
	{
		// Write a method to decide if two strings are anagrams or not

		// My first approach was to utilize two dictionary objects which use the character
		// as a key, and the count of that character in the string as a value. I walk
		// the strings and add the character when it's new, or increment the count when
		// I have seen it before. Finally I compare the keys and the values to see if they
		// match, which means they are anagrams.
		public static bool AreAnagrams(string s1, string s2)
		{
			if (s1 == null || s2 == null)
			{
				return false;
			}

			if (s1.Length != s2.Length)
			{
				return false;
			}

			var s1CharacterCount = new Dictionary<char, int>();

			var s2CharacterCount = new Dictionary<char, int>();

			foreach (char c in s1)
			{
				CheckAndAdd(s1CharacterCount, c);
			}

			foreach (char c in s2)
			{
				CheckAndAdd(s2CharacterCount, c);
			}

			foreach (var keyValuePair in s1CharacterCount)
			{
				// Check that the second contains all the characters of the first
				if (s2CharacterCount.ContainsKey(keyValuePair.Key))
				{
					// Compare the counts of each character
					if (!(keyValuePair.Value == s2CharacterCount[keyValuePair.Key]))
					{
						// If the count doesn't match, not an anagram
						return false;
					}
				}
				else
				{
					// If a character isn't found, not an anagram
					return false;
				}
			}

			return true;
		}

		private static void CheckAndAdd(Dictionary<char, int> dict, char c)
		{
			if (!dict.ContainsKey(c))
			{
				dict.Add(c, 1);
			}
			else
			{
				dict[c] = dict[c] + 1;
			}
		}

		// My second approach sorts the strings and checks for equality, which is simpler.
		public static bool AreAnagrams2(string s1, string s2)
		{
			if (s1 == null || s2 == null)
			{
				return false;
			}

			if (s1.Sort() == s2.Sort())
			{
				return true;
			}

			return false;
		}
	}
}