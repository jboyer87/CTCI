using System;
using System.Collections;
using System.Collections.Generic;

namespace CTCI.Questions.Chapter01
{
	public class Matrix
	{
		public Matrix(int rows, int columns)
		{
			Rows = rows;
			Columns = columns;

			Data = new int[rows, columns];

			Random random = new Random();

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{

					Data[i, j] = random.Next() % 10;
				}
			}
		}

		public void Print()
		{
			if (Columns != 0 && Rows != 0)
			{
				for (int i = 0; i < Rows; i++)
				{
					Console.Write("[");
					for (int j = 0; j < Columns; j++)
					{
						Console.Write(Data[i, j]);
						if (j == Columns - 1)
						{
							Console.Write("]\n");
						}
						else
						{
							Console.Write(" ");
						}
					}
				}
			}
		}

		public int Rows { get; set; }
		public int Columns { get; set; }
		public int[,] Data { get; set; }

	}

	public static class Question07
	{
		// Write an algorithm such that if an element in an MxN matrix is 0, its entire
		// row and column is set to 0.

		// I iterate through the matrix and keep a list of rows and columns that have a 0 
		// present, and then set all values that reside in those rows/columns to 0 during
		// a second pass of the matrix. This requires two passes.
		public static void SetToZero(this Matrix matrix)
		{
			List<int> rows = new List<int>();
			List<int> columns = new List<int>();

			for (int i = 0; i < matrix.Rows; i++)
			{
				for (int j = 0; j < matrix.Rows; j++)
				{
					if (matrix.Data[i, j] == 0)
					{
						rows.Add(i);
						columns.Add(j);
					}
				}
			}

			for (int i = 0; i < matrix.Rows; i++)
			{
				for (int j = 0; j < matrix.Rows; j++)
				{
					if (rows.Contains(i) || columns.Contains(j))
					{
						matrix.Data[i, j] = 0;
					}
				}
			}
		}
	}
}