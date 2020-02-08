using System;
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
	}
}
