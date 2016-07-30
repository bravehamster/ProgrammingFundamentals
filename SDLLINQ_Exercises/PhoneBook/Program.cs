using System;
using System.Collections.Generic;
using System.Linq;
namespace PhoneBook
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
			char[] arr = new char[]{ ' ' };
			int i = 0;
			List<List<string>> commands = new List<List<string>> ();
			while (true) {
				commands.Add ( Console.ReadLine ().Split (arr, StringSplitOptions.RemoveEmptyEntries).ToList ());
				if (commands[i][0] == "END") {
					break;
				}
				i++;
			}

			foreach (List<string> command in commands) {
				executeCommands (command, phonebook);
			}


		}

		static void executeCommands(List<string> contact, SortedDictionary<string, string> phonebook){
			if (contact[0] == "A") {
				if (!phonebook.ContainsKey (contact [1])) {
					phonebook.Add (contact [1], contact [2]);
				} 
				else 
				{
					phonebook [contact [1]] = contact [2];
				}
			}
			else if (contact[0] == "S") {
				if (phonebook.ContainsKey (contact[1])) {
					Console.WriteLine ("{0} -> {1}", contact[1], phonebook[contact[1]]) ;

				}
				else
				{
					Console.WriteLine ("Contact {0} does not exist.", contact[1]);
				}
			}
			else if (contact[0] == "ListAll") {
				phonebook.ToList ().ForEach (x=>Console.WriteLine ("{0} -> {1}", x.Key, x.Value));
			}

		}
	}
}
