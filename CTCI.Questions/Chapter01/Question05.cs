namespace CTCI.Questions.Chapter01
{
	public class Question05
	{
		// Write a method to replace all spaces in a string with '%20'

		// Strings are immutable in C#, and we cannot expand the size of an array either.
		// So, we need to create a copy of the string. In the code below, I walk the 
		// string and replace each instance of " " with "%20". I then return the encoded
		// version of the string.
		public static string EncodeSpaces(string s)
		{
			if (s == null)
			{
				return s;
			}

			string encoded = "";

			foreach (char c in s)
			{
				if (c == ' ')
				{
					encoded += "%20";
				}
				else
				{
					encoded += c;
				}
			}

			return encoded;
		}
	}
}