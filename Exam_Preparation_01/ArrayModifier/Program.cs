using System;
using System.Linq;

namespace ArrayModifier
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long[] arr = Console.ReadLine ().Split (' ').Select (long.Parse).ToArray ();
			bool keepLooping = true;
			while (keepLooping) {
				string[] cmd = Console.ReadLine ().Split (' ');

				switch (cmd[0]) {
				case "end":
					keepLooping = false;
					break;
				case "swap":
					arr = swapArrayElements (arr, cmd[1], cmd[2]);
					break;
				case "multiply":
					arr = multiplyArrayElements (arr, cmd [1], cmd [2]);
					break;
				case "decrease":
					arr = decreaseAllArrayElements(arr);
					break;
				default:
					break;
				}



			}

			Console.WriteLine (string.Join (", ", arr));

		
		}

		public static long[] swapArrayElements(long[] array, string idx1, string idx2){
			int index1 = int.Parse (idx1);
			int index2 = int.Parse (idx2);

			long tmp = array [index1];
			array [index1] = array [index2];
			array [index2] = tmp;
			return array;
		}

		public static long[] multiplyArrayElements(long[] array, string idx1, string idx2){
			int index1 = int.Parse (idx1);
			int index2 = int.Parse (idx2);

			long tmp = array [index1] * array [index2];
			array [index1] = tmp;
			return array;

		}

		public static long[] decreaseAllArrayElements(long[] array){
			for (int i = 0; i < array.Length; i++) {
				array [i] -= 1;
			}
			return array;
		}

	}
}
