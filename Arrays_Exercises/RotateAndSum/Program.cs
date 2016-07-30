using System;
using System.Linq;

namespace RotateAndSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int[] temparr = new int[arr.Length];
			int[] sumarr = new int[arr.Length];
			int n = int.Parse(Console.ReadLine());
			for (int r = 0; r < n; r++) {
				for (int i = 0; i < arr.Length; i++) {
					temparr [(i + r + 1) % temparr.Length] = arr[i];
				}
				for (int i = 0; i < arr.Length; i++) {
					sumarr [i] += temparr [i];
				}
			}

			Console.WriteLine (string.Join(" ", sumarr));

		}
	}
}
