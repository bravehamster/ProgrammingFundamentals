using System;

namespace MatrixOfLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int rows = int.Parse (Console.ReadLine ());
			int cols = int.Parse (Console.ReadLine ());

			char[][]matrix = new char[rows][];

			for (int i = 0; i < rows; i++) {
				matrix[i] = new char[cols];
				for (int j = 0; j < matrix[i].Length; j++) {
					matrix [i] [j] = (char)(65 + j + i*matrix[i].Length); 
				}

			}

			foreach (char[] row in matrix) {
				Console.WriteLine (string.Join (" ", row));
			}

		}
	}
}
