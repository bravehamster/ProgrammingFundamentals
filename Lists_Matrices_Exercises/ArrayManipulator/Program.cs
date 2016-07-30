using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
						
			List<long> numbers = Console.ReadLine ().Split (' ').Select (long.Parse).ToList ();

			List<string[]> commands = new List<string[]> ();

			while (true) {
				string[] currCommand = Console.ReadLine ().Split (' ') ;
				commands.Add (currCommand);
				if (currCommand[0]=="print") {
					break;
				}
			}

			for (int i = 0; i < commands.Count; i++) {
				editArray (numbers, commands[i]);
			}




		}

		static void editArray(List<long> arr, string[] currCommand){
			string currCommandWord = currCommand [0];
			switch (currCommandWord) {

			case "add":
				arr.Insert (int.Parse (currCommand[1]), long.Parse (currCommand[2]));
				break;

			case "addMany":
				for (int i = currCommand.Length-1; i >= 2; i--) {
					arr.Insert (int.Parse (currCommand [1]), long.Parse (currCommand [i]));
				}
				break;


			case "contains":
				bool contains = false;
				for (int i = 0; i < arr.Count; i++) {
					if (long.Parse (currCommand [1]) == arr [i]) {
						Console.WriteLine ("0");
						contains = true;
						break;
					} 
				}
				if (!contains) {
					Console.WriteLine ("-1");
				}

				break;


			case "remove":
				arr.RemoveAt (int.Parse (currCommand[1]));
				break;


			case "shift":
				long[] toShift = new long[arr.Count];
				int n = int.Parse (currCommand [1]);
				int mod = arr.Count;
				for (int i = 0; i < arr.Count; i++) {
					toShift [i] = arr [(i + n) % mod];

				}
				for (int i = 0; i < arr.Count; i++) {
					arr [i] = toShift [i];
				}
				break;


			case "sumPairs":
				int end = arr.Count/2;
				for (int i = 1; i <= end; i++) {
					arr [i] += arr [i - 1];
					arr.RemoveAt (i-1);
				}
				break;


			case "print":
				Console.WriteLine ("[" + string.Join (", ", arr) + "]");
				break;
			default:
				Console.WriteLine ("unrecognized command");
				break;
			}

		}
	}
}
