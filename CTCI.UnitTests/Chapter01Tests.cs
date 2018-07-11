using System;
using System.Collections.Generic;
using System.Diagnostics;
using CTCI.Questions.Chapter01;
using Xunit;

namespace CTCI.UnitTests
{
	public class Chapter01Tests
	{
		[Fact]
		public void Question01Should()
		{
			Assert.False(Question01.HasUniqueCharacters("aa"));
			Assert.False(Question01.HasUniqueCharacters2("aa"));

			Assert.False(Question01.HasUniqueCharacters("This is just a string"));
			Assert.False(Question01.HasUniqueCharacters2("This is just a string"));

			Assert.True(Question01.HasUniqueCharacters("aA"));
			Assert.True(Question01.HasUniqueCharacters2("aA"));

			Assert.True(Question01.HasUniqueCharacters("abcdefg"));
			Assert.True(Question01.HasUniqueCharacters2("abcdefg"));

			Assert.False(Question01.HasUniqueCharacters("  "));
			Assert.False(Question01.HasUniqueCharacters2("  "));

			// Add all ascii characters to a string to check
			string allAsciiCharacters = "";

			for (int i = 0; i <= 255; i++)
			{
				char c = (char)i;
				allAsciiCharacters += c;
			}

			Assert.True(Question01.HasUniqueCharacters(allAsciiCharacters));
			Assert.True(Question01.HasUniqueCharacters2(allAsciiCharacters));

			// Add a duplicate character to check again
			allAsciiCharacters += (char)0;

			Assert.False(Question01.HasUniqueCharacters(allAsciiCharacters));
			Assert.False(Question01.HasUniqueCharacters2(allAsciiCharacters));
		}

		[Fact]
		public void Question02Should()
		{
			Assert.Equal("dcba", Question02.Reverse("abcd"));
		}
	}
}
