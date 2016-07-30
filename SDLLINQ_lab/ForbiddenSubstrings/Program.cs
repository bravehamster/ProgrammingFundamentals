using System;

namespace ForbiddenSubstrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string input = Console.ReadLine ();
			string[] fb =  Console.ReadLine ().Split (' ');


			foreach (var wrd in fb) {
				input = input.Replace (wrd, new String ('*', wrd.Length));
			}


			Console.WriteLine (input);


		}
	}
}
