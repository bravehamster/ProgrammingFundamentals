using System;
using System.Linq;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;

namespace FoldAndSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int arrmod = arr.Length / 4;

			IEnumerable<int> topLeft = arr.Take (arrmod).Reverse ();
			IEnumerable<int> topRight = arr.Reverse ().Take (arrmod);
		
			int[] topRow = topLeft.Concat (topRight).ToArray ();
			int[] botRow = arr.Skip (arrmod).Take (2 * arrmod).ToArray ();

			IEnumerable<int> sum = topRow.Select ((x, idx) => x+= botRow[idx]);

			Console.WriteLine (string.Join (" ", sum));
		

		}
	}
}
