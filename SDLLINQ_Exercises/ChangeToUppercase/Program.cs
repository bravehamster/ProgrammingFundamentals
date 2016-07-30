using System;
using System.Collections.Generic;
using System.Linq;
namespace ChangeToUppercase
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string text = Console.ReadLine ();
			int counter = 0;

			for (int i = 0; i < text.Length; i++) {
				if (text[i] == '<') {
					string command = text.Substring (i, getCloseBracketIdx (text, i+1)-i+1);
					if (command == "<upcase>") {
						string tmp = text.Substring (i+8, getNextIdx (text, i+1)-i-8);
						text = text.Remove (i, 8+9+tmp.Length);
						text = text.Insert (i, tmp.ToUpper ());
						counter++;	
					}
					
				}
			}

			Console.WriteLine (text);

		}

		static int getNextIdx(string txt, int currIdx){
			int idx = -1;
			for (int i = currIdx; i < txt.Length; i++) {
				if (txt[i] == '<' && txt[i+1] == '/') {
					idx = i;
					break;
				}
			}
			return idx;

		}
		static int getCloseBracketIdx(string txt, int currIdx){
			int idx = -1;
			for (int i = currIdx; i < txt.Length; i++) {
				if (txt[i] == '>') {
					idx = i;
					break;
				}
			}
			return idx;
		}

	}
}