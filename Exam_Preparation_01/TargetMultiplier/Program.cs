using System;
using System.Linq;

namespace TargetMultiplier
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] matrixDims = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			long[][] matrix = new long[matrixDims [0]][];

			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ').Select (long.Parse).ToArray (); 
			}

			int[] pos = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			//Get a targeted cell and multiply its value with the sum of all neighboring cells
			//The neighboring cells must change their values too. Each one should be the product of its initial value and the initial value of the targeted cell.

			long sumPos = 0;
			long targetedCellInitValue = matrix [pos [0]] [pos [1]];

			for (int i = pos[0]-1; i <= pos[0]+1; i++) {
				for (int j = pos[1]-1; j <= pos[1]+1; j++) {
					if (i == pos[0] && j==pos[1]) {
						matrix [i] [j] = targetedCellInitValue;
					}else{
						sumPos += matrix [i] [j];
						matrix [i] [j] = targetedCellInitValue * matrix [i] [j];	
					}

				}
			}
				
			matrix [pos [0]] [pos [1]] = matrix [pos [0]] [pos [1]] * sumPos;


			for (int i = 0; i < matrix.Length; i++) {
				Console.WriteLine (string.Join (" ", matrix[i]));
			}


		}
	}
}
