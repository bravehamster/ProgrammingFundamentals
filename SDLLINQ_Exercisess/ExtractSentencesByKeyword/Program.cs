using System;
using System.Linq;

namespace ExtractSentencesByKeyword
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			char[] ending = new char[]{ '.', '!', '?' };
			string theOneWord = Console.ReadLine ();
			string[] text = Console.ReadLine ().Split (ending);
			string[] textorig = new string[text.Length];
			for (int i = 0; i < text.Length; i++) {
				textorig [i] = text [i];
			}
			string[][] words = new string[text.Length][];


			for (int i = 0; i < text.Length; i++) {
				for (int j = 0; j < text[i].Length; j++) {
					if (!char.IsLetter (text[i][j])) {
						text[i] = text [i].Replace (text [i][j], ' ');
					}	

				}
			}
				

			for (int i = 0; i < text.Length; i++) {
				words [i] = text [i].Split (' ');
			}


			for (int i = 0; i < words.Length; i++) {
				for (int j = 0; j < words[i].Length; j++) {
					if (words[i][j] == theOneWord) {
						Console.WriteLine (string.Join (" ",textorig[i].Split ().Where (x=>x!="")));
					}
				}
			}

		
		
		}
	}
}
