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

			Assert.True(Question01.HasUniqueCharacters(null));
			Assert.True(Question01.HasUniqueCharacters2(null));

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

		[Fact]
		public void Question03Should()
		{
			string test1 = "abcd";
			Question03.RemoveDuplicateCharacters(ref test1);

			string test2 = "abcdd";
			Question03.RemoveDuplicateCharacters(ref test2);

			string test3 = "abc d ";
			Question03.RemoveDuplicateCharacters(ref test3);

			string test4 = null;
			Question03.RemoveDuplicateCharacters(ref test4);

			string test5 = "aaaa";
			Question03.RemoveDuplicateCharacters(ref test5);

			string test6 = "ababab";
			Question03.RemoveDuplicateCharacters(ref test6);

			Assert.Equal("abcd", test1);
			Assert.Equal("abcd", test2);
			Assert.Equal("abc d", test3);
			Assert.Equal(null, test4);
			Assert.Equal("a", test5);
			Assert.Equal("ab", test6);
		}

		[Fact]
		public void Question04Should()
		{
			Assert.True(Question04.AreAnagrams("aabbccdd", "abbacddc"));
			Assert.True(Question04.AreAnagrams("abcd", "dcba"));
			Assert.False(Question04.AreAnagrams("aabbccdd", "dcba"));
			Assert.False(Question04.AreAnagrams(null, null));
			Assert.False(Question04.AreAnagrams(null, "abcd"));
			Assert.False(Question04.AreAnagrams("abcd", null));
			Assert.True(Question04.AreAnagrams("a man a plan a canal panama", "a plan a man a canal panama"));
			Assert.False(Question04.AreAnagrams("A man a plan a canal panama", "a plan a man a canal panama"));
			Assert.False(Question04.AreAnagrams("wxyz", "abcd"));

			Assert.True(Question04.AreAnagrams2("aabbccdd", "abbacddc"));
			Assert.False(Question04.AreAnagrams2(null, null));
			Assert.False(Question04.AreAnagrams2(null, "abcd"));
			Assert.False(Question04.AreAnagrams2("abcd", null));
		}
	}
}
