using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixOfPalindromes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] inputNums = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int r = inputNums[0];
			int c = inputNums[1];

			string[][] matrix = new string[r][];
			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = new string[c];
			}

			for (int i = 0; i < matrix.Length; i++) {
				for (int j = 0; j < matrix[i].Length; j++) {
					matrix [i] [j] = ((char) (i+97)).ToString () + ((char) (i+j+97)).ToString () + ((char) (i+97)).ToString () + " ";
					Console.Write (matrix[i][j]);
				}
				Console.WriteLine ();
			}
		}
	}
}