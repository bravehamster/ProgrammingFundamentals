using System;
using System.Linq;

namespace FoldAndSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int[] foldBottom = new int[arr.Length / 2];
			int[] foldTopLeft = new int[arr.Length / 4];
			int[] foldTopRight = new int[arr.Length / 4];
			int[] foldTop = new int[arr.Length / 2];

			int k = arr.Length / 4;

			for (int i = 0; i < arr.Length; i++) {
				if (i>=k && i < 3*k) {
					foldBottom [i-k] = arr [i];
				}
				if (i<k) {
					foldTopLeft [i] = arr [i];
				}
				if (i>=3*k) {
					foldTopRight [i - (3 * k )] = arr [i];
				}
			}

			Array.Reverse (foldTopLeft);
			Array.Reverse (foldTopRight);

			for (int i = 0; i < foldTop.Length; i++) {
				if (i<foldTop.Length/2) {
					foldTop [i] = foldTopLeft [i];
				} else {
					foldTop [i] = foldTopRight [i  - foldTop.Length/2];
				}
			}


			for (int i = 0; i < foldTop.Length; i++) {
				foldTop [i] += foldBottom [i];
			}

			Console.WriteLine (string.Join(" ", foldTop));

		}
	}
}
