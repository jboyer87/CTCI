using CTCI.DataStructures;
using CTCI.Questions.Chapter02;

using Xunit;

namespace CTCI.UnitTests
{
	public class Chapter02Tests
	{
		[Fact]
		public void Question01Should()
		{
			var linkedList = new LinkedList<int>();

			linkedList.AppendToTail(1);
			linkedList.AppendToTail(2);
			linkedList.AppendToTail(2);
			linkedList.AppendToTail(3);
			linkedList.AppendToTail(3);

			Question01<int>.RemoveDuplicates(linkedList);

			var expected = new LinkedList<int>();

			expected.AppendToTail(1);
			expected.AppendToTail(2);
			expected.AppendToTail(3);

			int expectedFirst = expected.Head.Value;
			int expectedSecond = expected.Head.Next.Value;
			int expectedThird = expected.Head.Next.Next.Value;

			int actualFirst = linkedList.Head.Value;
			int actualSecond = linkedList.Head.Next.Value;
			int actualThird = linkedList.Head.Next.Next.Value;

			Assert.Equal(expectedFirst, actualFirst);
			Assert.Equal(expectedSecond, actualSecond);
			Assert.Equal(expectedThird, actualThird);
		}
	}
}
