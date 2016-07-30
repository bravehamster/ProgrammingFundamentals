using System;
using System.Linq;
namespace Capitalisation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] split = new char[]{' ', '.', ',', ';', '!', '?', ',', ',' };
			string[] text = Console.ReadLine ().Split (split, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < text.Length; i++) {
				string c = text[i].Substring (0, 1).ToUpper ();
				text [i] = text [i].Remove (0, 1);
				text [i] = string.Concat (c,text[i]);
			}

			Console.WriteLine (string.Join (" ", text));
		}
	}
}
