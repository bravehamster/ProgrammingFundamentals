using System;
using System.Collections.Generic;

class MainClass
{
	public static void Main (string[] args)
	{

		List<string> phrases = new List<string> () { 
			"Excellent product.",
			"Such a great product.", 
			"I always use that product.",
			"Best product of its category.",
			"Exceptional product.", 
			"I can't live without this product."
		};

		List<string> events = new List<string> () {
			"Now I feel good.",
			"I have succeeded with this product.",
			"Makes miracles. I am happy of the results!",
			"I cannot believe but now I feel awesome.",
			"Try it yourself, I am very satisfied.",
			"I feel great!"
		};

		List<string> authors = new List<string> (){ "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

		List<string> cities = new List<string> (){ "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

		Random rnd = new Random ();


		List<Message> messages = new List<Message> ();

		int numMessages = int.Parse (Console.ReadLine ());

		for (int i = 0; i < numMessages; i++) {
			int randPhrase  = rnd.Next (0, phrases.Count);
			int randEvent 	= rnd.Next (0, events.Count);
			int randAuthor 	= rnd.Next (0, authors.Count);
			int randCity 	= rnd.Next (0, cities.Count);

			messages.Add ( new Message (){ phrase = phrases [randPhrase], msgEvent = events[randEvent], author = authors[randAuthor], city = cities[randCity] });
		}

		foreach (var msg in messages) {
			Console.WriteLine ("{0} {1} {2} - {3}", msg.phrase, msg.msgEvent, msg.author, msg.city);
		}

	}
}

class Message
{
	public string phrase {
		get;
		set;
	}
	public string msgEvent {
		get;
		set;
	}
	public string author {
		get;
		set;
	}
	public string city {
		get;
		set;
	}





}