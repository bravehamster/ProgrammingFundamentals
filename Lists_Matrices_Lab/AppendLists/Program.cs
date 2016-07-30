using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendLists
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<string> inputList = Console.ReadLine ().Split ('|').ToList();

			List<string> outputList = new List<string>();

			inputList.Reverse();

			foreach (string input in inputList) {
				string[] arr = input.Split(' ');
				foreach (string item in arr) {
					if (item!="") {
						outputList.Add(item);
					}
				}
			}

			Console.WriteLine (string.Join(" ", outputList));

		}
	}
}
