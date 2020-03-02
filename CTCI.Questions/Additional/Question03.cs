using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.Questions.Additional
{
	// Write a function to flatten a multi-dimensional array.

	// The approach here is to get the width/height of the array so that you can declare an
	// array of the appropriate size (width * height = size of new array) and begin adding
	// to it. This avoids any unnecessary resizing of the array later, or having to use an
	// intermediary list or something while building the array which would lead to worse
	// time/space complexity. Once we have the size, we can use nested for loops to fill the
	// array and then return it.
	public class Question03
	{
		public static T [] FlattenArray<T>(T [,] array)
		{

			int width = array.GetLength(0);
			int height = array.GetLength(1);

			var result = new T[width * height];

			int currentIndex = 0;

			for(int i = 0; i < width; i++)
			{
				for(int j = 0; j < height; j++)
				{
					result[currentIndex] = array[i, j];
					currentIndex++;
				}
			}

			return result;
		}
	}
}
