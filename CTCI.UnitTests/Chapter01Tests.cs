using System;
using System.Collections.Generic;
using CTCI.Questions.Chapter01;
using Xunit;

namespace CTCI.UnitTests
{
	public class Chapter01Tests
	{
		[Fact]
		public void Question01Should()
		{
			// a, a
			Assert.False(Question01.HasUniqueCharacters("aa"));

			// Several letters are the same
			Assert.False(Question01.HasUniqueCharacters("This is just a word string"));

			// a and A are different characters
			Assert.True(Question01.HasUniqueCharacters("aA"));

			// all unique
			Assert.True(Question01.HasUniqueCharacters("abcdefg"));

			// spaces are not distinct
			Assert.False(Question01.HasUniqueCharacters("  "));
		}

		[Fact]
		public void Question02Should()
		{
			Assert.Equal("dcba", Question02.Reverse("abcd"));
		}
	}
}
