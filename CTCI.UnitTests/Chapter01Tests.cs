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
			Assert.Equal(Question01.HasUniqueCharacters("aa"), false);

			// Several letters are the same
			Assert.Equal(Question01.HasUniqueCharacters("This is just a word string"), false);

			// a and A are different characters
			Assert.Equal(Question01.HasUniqueCharacters("aA"), true);

			// all unique
			Assert.Equal(Question01.HasUniqueCharacters("abcdefg"), true);

			// spaces are not distinct
			Assert.Equal(Question01.HasUniqueCharacters("  "), false);
		}
	}
}
