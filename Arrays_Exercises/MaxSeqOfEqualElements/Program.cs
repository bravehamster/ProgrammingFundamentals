using System;
using System.Linq;

namespace MaxSeqOfEqualElements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray();

			int len = 1;
			int startIndex = 0;
			int longest = -1;
			int longestStartIndex = -1;

			for (int i = 0; i < Math.Max(arr.Length-1, 0); i++) {
				if (arr [i] == arr [i + 1]) {
					if (len==1) {
						startIndex = i;
					}
					len++;
				} else {
					if (len>longest) {
						longest = len;
						longestStartIndex = startIndex;
					}
					len = 1;
				}

			}

			if (len>longest) {
				longest = len;
				longestStartIndex = startIndex;
			}

			if (longestStartIndex==-1 || longest==-1) {
				longest = len;
				longestStartIndex = startIndex;
			}

			for (int i = longestStartIndex; i < longestStartIndex+longest; i++) {
				Console.Write (arr[i] + " ");
			}



		}
	}
}
