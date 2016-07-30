using System;
using System.Linq;

namespace SquaresInAMatrix
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			int[] dimensions = Console.ReadLine ().Split (' ').Select (int.Parse ).ToArray ();
			int rows = dimensions [0];
			char[][] matrix = new char[rows][];
			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ').Select (char.Parse).ToArray ();
			}
			int numsuqares = 0;

			for (int i = 0; i < matrix.Length-1; i++) {
				for (int j = 1; j < matrix[i].Length; j++) {
					
					if (matrix [i] [j] == matrix [i] [j - 1] && matrix [i] [j] == matrix [i + 1] [j] && matrix [i] [j] == matrix [i+1] [j - 1] ) {
						numsuqares++;
					} 
					
				}
			}
			Console.WriteLine (numsuqares);

		}
	}
}