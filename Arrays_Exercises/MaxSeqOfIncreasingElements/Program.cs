using System;
using System.Linq;

namespace MaxSeqOfIncreasingElements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int counter = 1;
			int currindex = 0;
			int largestCount = 0;
			int largestIndex = 0;
			for (int i = 1; i < arr.Length; i++) {
				if (arr[i] > arr[i-1]) {
					if (counter == 1) {
						currindex = i-1;
					}
					counter++;
					if ((i == arr.Length-1) && counter > largestCount) {
						largestCount = counter;
						largestIndex = currindex;

					}
				} else {
					if (counter>largestCount) {
						largestCount = counter;
						largestIndex = currindex;
					}
					counter = 1;
				}
			}

			for (int i = largestIndex; i < largestIndex+largestCount; i++) {
				Console.Write (arr[i] + " ");
			}

		} 
	}
}
