using System;
using System.Collections.Generic;
using CTCI.Questions.Additional;
using Xunit;

namespace CTCI.UnitTests
{
	public class AdditionalTests
	{
		[Fact]
		public void Question01ShouldMergeSort()
		{

			int[] first = new int[] {
				10, 25, 43, 199
			};

			int[] second = new int[] {
				1, 14, 22, 2000
			};

			int[] merged = Question01.MergeAndSort(first, second);

			int[] expected = new int[] {
				1, 10, 14, 22, 25, 43, 199, 2000
			};

			Assert.Equal(expected, merged);
		}

		[Fact]
		public void Question01ShouldMergeSortWithEqualNumbers()
		{

			int[] first = new int[] {
				10, 25, 43, 199
			};

			int[] second = new int[] {
				10, 25, 43, 199
			};

			int[] merged = Question01.MergeAndSort(first, second);

			int[] expected = new int[] {
				10, 10, 25, 25, 43, 43, 199, 199
			};

			Assert.Equal(expected, merged);
		}

		[Fact]
		public void Question02ShouldFindPalindromes()
		{
			string input = "Test! aabbaa ccc";

			var expected = new List<string>();

			int expectedSize = 2;

			string expected1 = " aabbaa ";
			string expected2 = "ccc";

			expected.Add(expected1);
			expected.Add(expected2);

			List<string> actual = Question02.FindPalindromes(input);

			Assert.Equal(expectedSize, actual.Count);
			Assert.Contains(expected1, actual);
			Assert.Contains(expected2, actual);
		}
	}
}
