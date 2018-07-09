namespace CTCI.Questions.Chapter01
{
	public class Question02
	{
		// Write code to reverse a C-Style String (C-String means that "abcd" is 
		// represented as 5 characters, including the null character).

		// Time complexity is O(n), space complexity is O(n)
		public static string Reverse(string s)
		{
			string reversed = "";

			for (int i = s.Length - 1; i >= 0; i--)
			{
				reversed += s[i];
			}

			return reversed;
		}

		// Strings are immutable in C#, so we cannot reverse the string in place. In C++,
		// we could do something like this:
		/*
		std::string reverse(std::string s)
		{
			int midpoint = s.length() / 2;

			int start = 0;

			int end = s.length() - 1;

			while (start < midpoint)
			{
				std::swap(s[start], s[end]);

				start++;

				end--;
			}

			return s;
		}
		*/

	}
}