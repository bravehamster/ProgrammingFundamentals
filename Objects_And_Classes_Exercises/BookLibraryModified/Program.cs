using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class MainClass
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine ());
		Library mylib = new Library ();
		List<Book> currbooksList = new List<Book> ();
		for (int i = 0; i < n; i++) {
			string[] input = Console.ReadLine ().Split (' ');
			Book curr = new Book (){
				title=input[0],
				author = input[1],
				publisher = input[2],
				releaseDate = DateTime.ParseExact (input[3].Trim (), "dd.MM.yyyy", CultureInfo.InvariantCulture),
				ISBN = input[4],
				price = double.Parse (input[5])
			};
			
			currbooksList.Add (curr);
		}
		DateTime checkReleaseDate = DateTime.ParseExact (Console.ReadLine (), "dd.MM.yyyy", CultureInfo.InvariantCulture );
		mylib.booksList = currbooksList;

		Dictionary<string, DateTime> output = new Dictionary<string, DateTime> ();

		foreach (var book in mylib.booksList) {
			if (!output.ContainsKey (book.title)) {
				output.Add (book.title, book.releaseDate);
			}
		}

		foreach (var book in mylib.booksList) {
			output [book.title] = book.releaseDate;
		}


		var toPrint = output.OrderBy (x => x.Value.Year).ThenBy (x=>x.Value.Month).ThenBy (x=>x.Value.Day).ThenBy (x => x.Key);

		foreach (var book in toPrint)
		{
			if (book.Value.Date >= checkReleaseDate.Date) {
				Console.WriteLine("{0} -> {1}", book.Key, book.Value.ToString ("dd.MM.yyyy") );
			}
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
	public DateTime releaseDate {
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