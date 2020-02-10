using System;
using Xunit;
using CTCI.DataStructures;
using CTCI.Questions.Chapter02;

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

		[Fact]
		public void Question01NoBufferShould()
		{
			var linkedList = new LinkedList<int>();

			linkedList.AppendToTail(1);
			linkedList.AppendToTail(2);
			linkedList.AppendToTail(2);
			linkedList.AppendToTail(3);
			linkedList.AppendToTail(3);

			Question01<int>.RemoveDuplicatesNoBuffer(linkedList);

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

		[Fact]
		public void Question02Should()
		{
			var linkedList = new LinkedList<int>();
			
			linkedList.AppendToTail(1);
			linkedList.AppendToTail(2);
			linkedList.AppendToTail(3);
			linkedList.AppendToTail(4);
			linkedList.AppendToTail(5);

			Node<int> expected = linkedList.Head.Next.Next.Next; // 4

			Node<int> actual = Question02<int>.GetNthToLastElement(linkedList, 2);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Question02ShouldThrowArgumentException()
		{
			var linkedList = new LinkedList<int>();

			linkedList.AppendToTail(1);
			linkedList.AppendToTail(2);
			linkedList.AppendToTail(3);
			linkedList.AppendToTail(4);
			linkedList.AppendToTail(5);

			Assert.Throws<ArgumentException>(
				() => (Question02<int>.GetNthToLastElement(linkedList, 6))
			);
		}
	}
}
