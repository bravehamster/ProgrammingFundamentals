using System;
using System.Linq;

namespace MostFrequentNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long[] arr = Console.ReadLine ().Split (' ').Select (long.Parse).ToArray ();
			int counter = 0;
			long max =  0;
			long number =  arr[0];

			for (int i = 0; i < arr.Length; i++) {
				for (int j = 0; j < arr.Length; j++) {
					if (arr[i]==arr[j]) {
						counter++;
					}
				}
				if (counter>max) {
					max = counter;
					number = arr [i];
				}
				counter = 0;
			}

			//Console.WriteLine (number + " occurs " + max + "times.");
			Console.WriteLine (number);
		}
	}
}
