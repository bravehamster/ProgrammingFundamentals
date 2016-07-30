using System;
using System.Linq;

namespace EqualSums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numarr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int leftSum = 0;
			int rightSum = 0;

			for (int i = 0; i <= numarr.Length-1; i++) {
				if (numarr.Length == 1) {
					Console.WriteLine ("0");
					return;
				}

				leftSum = 0;
				rightSum = 0;

				for (int j = 0; j < i; j++) {
					leftSum += numarr [j];
				}
				for (int k = i+1; k < numarr.Length; k++) {
					rightSum += numarr [k];
				}

				if (leftSum == rightSum) {
					Console.WriteLine (i);
					return;
				}
			}
			Console.WriteLine ("no");
		}
	}
}
