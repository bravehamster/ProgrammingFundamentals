using System;
using System.Linq;
using System.Collections.Generic;

namespace URLParser
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string url = Console.ReadLine ();
			bool hasProtocol = false;
			for (int i = 0; i < url.Length; i++) {
				if (url[i] == ':') {
					hasProtocol = true;
					break;
				}
			}

			if (hasProtocol) {
				url = url.Replace ("://", " ");
				url = url.Replace ("/", " ");
				List<string> output = url.Split (' ').ToList ();



				Console.WriteLine ("[protocol] = \"{0}\"", output[0]);
				Console.WriteLine ("[server] = \"{0}\"", output[1]);
				for (int i = 0; i < 2; i++) {
					output.RemoveAt (0);
				}
				Console.WriteLine ("[resource] = \"{0}\"", string.Join ("/",output.Select((x, idx)=> x = output[idx])));
			} 
			else {
				
				url = url.Replace ("/", " ");
				List<string> output = url.Split (' ').ToList ();



				Console.WriteLine ("[protocol] = \"\"");
				Console.WriteLine ("[server] = \"{0}\"", output[0]);
				output.RemoveAt (0);
				
				Console.WriteLine ("[resource] = \"{0}\"", string.Join ("/",output.Select((x, idx)=> x = output[idx])));
			}




		}
	}
}
