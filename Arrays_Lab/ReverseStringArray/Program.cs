using System;

namespace ReverseStringArray
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] arr = Console.ReadLine ().Split (' ');

			for (int i = 0; i < arr.Length/2; i++) {
				string first = arr [i];
				string last = arr [arr.Length - 1 - i];
				arr [i] = last;
				arr [arr.Length - 1 - i] = first;
			}

			foreach (var item in arr) {
				Console.Write (item + " ");
			}

		}
	}
}
