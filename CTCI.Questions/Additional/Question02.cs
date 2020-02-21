using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.Questions.Additional
{
	// Write and algorithm that takes a string and returns all palindromes contained within the 
	// string, ignoring other smaller palindromes contained inside of larger ones.
	public class Question02
	{
		public static List<string> FindPalindromes(string input)
		{
			var palindromes = new List<string>();

			for(int i = 0; i < input.Length; i++)
			{
				for(int j = input.Length - 1; j > i; j--)
				{
					string possiblePalindrome = input.Substring(i, (j + 1) - i );

					if (IsPalindrome(possiblePalindrome))
					{
						palindromes.Add(possiblePalindrome);
						// To avoid adding duplicate palindromes in this range, set i to j to skip
						// ahead.
						i = j;
						break;
					}
				}
			}

			return palindromes;
		}

		private static bool IsPalindrome(string input)
		{
			int midpoint = (input.Length / 2) - 1;

			int j = input.Length - 1;

			for(int i = 0; i <= midpoint; i++)
			{
				if(input[i] != input[j])
				{
					return false;
				}

				j--;
			}

			return true;
		}
	}
}
