using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> inputList = Console.ReadLine ().Split (' ').Select (int.Parse).ToList ();

			int startIndex = 0;
			int bestIndex = 0;
			int count = 1;
			int longest = 1;

			for (int i = 0; i < inputList.Count-1; i++) {
				if (inputList [i] == inputList [i + 1]) {
					count++;
					if (count == 2) {
						startIndex = i;
					}
				} else {
					count = 1;
				}

				if (count>longest) {
					longest = count;
					bestIndex = startIndex;
				}

			}

			for (int i = bestIndex; i < bestIndex+longest; i++) {
				Console.Write (inputList[i] + " ");
			}



		}
	}
}
