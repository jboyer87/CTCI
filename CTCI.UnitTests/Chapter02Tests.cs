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

		[Fact]
		public void Question03Should()
		{
			var actual = new LinkedList<int>();

			actual.AppendToTail(1);
			actual.AppendToTail(2);
			actual.AppendToTail(3);
			actual.AppendToTail(4);
			actual.AppendToTail(5);

			var middleNode = actual.Head.Next.Next; // 3

			Question03<int>.RemoveNodeFromList(ref middleNode);

			var expected = new LinkedList<int>();

			expected.AppendToTail(1);
			expected.AppendToTail(2);
			expected.AppendToTail(4);
			expected.AppendToTail(5);

			Node<int> actualRunner = actual.Head;
			Node<int> expectedRunner = expected.Head;

			// Check each value in the lists against each other
			while (actualRunner != null)
			{
				Assert.Equal(expectedRunner.Value, actualRunner.Value);
				actualRunner = actualRunner.Next;
				expectedRunner = expectedRunner.Next;
			}
		}
	}
}
