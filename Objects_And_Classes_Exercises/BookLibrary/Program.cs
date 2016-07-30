using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine ());
		Library mylib = new Library ();
		List<Book> currbooksList = new List<Book> ();
		for (int i = 0; i < n; i++) {
			string[] input = Console.ReadLine ().Split (' ');
			Book curr = new Book (){title=input[0], author = input[1], publisher = input[2], releaseDate = input[3], ISBN = input[4], price = double.Parse (input[5])};
			currbooksList.Add (curr);
		}
		mylib.booksList = currbooksList;

		Dictionary<string, double> output = new Dictionary<string, double> ();

		foreach (var book in mylib.booksList) {
			if (!output.ContainsKey (book.author)) {
				output.Add (book.author, 0);
			}
		}

		foreach (var book in mylib.booksList) {
			output [book.author] += book.price;
		}


		var toPrint = output.OrderByDescending (x => x.Value).ThenBy (x => x.Key);

		foreach (var author in toPrint)
		{
			Console.WriteLine("{0} -> {1:f2}", author.Key, author.Value);
		}
	}
}

class Book
{
	public string title {
		get;
		set;
	}
	public string author {
		get;
		set;
	}
	public string publisher {
		get;
		set;
	}
	public string releaseDate {
		get;
		set;
	}
	public string ISBN {
		get;
		set;
	}
	public double price {
		get;
		set;
	}



}

class Library
{
	public string name {
		get;
		set;
	}

	public List<Book> booksList {
		get;
		set;
	}






}