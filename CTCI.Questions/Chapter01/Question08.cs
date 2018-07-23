namespace CTCI.Questions.Chapter01
{
	public static class Question08
	{
		// Assume you have a method isSubstring which checks is one word is a substring of
		// another. Given two strings, s1 and s2, write code to check if s2 is a rotation 
		// of s1 using only one call to isSubstring (i.e., "waterbottle" is a rotation of 
		// "erbottlewat").

		// The solution to this is almost like a brainteaser. If the word is rotated, you
		// can concatenate it with itself to get a version of the string that contains
		// the original word. Example: 
		// erbottlewat --> erbottlewaterbottlewat.
		//                         ^^^^^^^^^^^
		// Check to see if the original word is a substring of the concatenated version.

		// Implementation of IsSubstring
		public static bool IsSubstring(this string original, string check)
		{
			return check.Contains(original);
		}

		// Method that calls IsSubstring once
		public static bool IsRotationOf(this string original, string check)
		{
			if (original == null || check == null)
			{
				return false;
			}

			if (original.Length != check.Length)
			{
				return false;
			}

			string concatenated = original + original;

			return check.IsSubstring(concatenated);
		}
	}
}