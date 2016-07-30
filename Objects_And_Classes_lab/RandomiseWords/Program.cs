using System;

namespace RandomiseWords
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] words = Console.ReadLine ().Split (' ');
			Random rnd = new Random ();
			int idx = 0;
			for (int i = 0; i < words.Length/2; i++) {
				idx = rnd.Next (0, words.Length-i);
				string tmp = words [i];
				words [i] = words [idx];
				words [idx] = tmp;
			}
			foreach (var w in words) {
				Console.WriteLine (w);
			}




		}
	}
}
