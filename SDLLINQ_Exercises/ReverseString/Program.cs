using System;
using System.Linq;

namespace ReverseString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] input = Console.ReadLine ().ToCharArray ();
		
			/*for (int i = 0; i < input.Length/2; i++) {
				char keep = input [input.Length-1-i];
				input [input.Length - 1 - i] = input [i];
				input [i] = keep;
			}

			Console.WriteLine (new String(input));

			*/

			for (int i = input.Length-1; i >= 0; i--) {
				Console.Write (input[i]);
			}



		}
	}
}