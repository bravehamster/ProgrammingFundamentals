using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
	public static void Main (string[] args)
	{
		int numSales = int.Parse (Console.ReadLine ());

		List<Sale> sales = new List<Sale> ();

		for (int i = 0; i < numSales; i++) {
			sales.Add (Sale.ReadSale ());
		}

		string[] towns = sales.Select (x => x.town).OrderBy (x=>x). Distinct (). ToArray ();

		foreach (var town in towns) {
			decimal total = sales.Where (x => x.town == town).Sum (x => x.price * x.quantity);
			Console.WriteLine ("{0} -> {1:f2}", town, total);
		}

	}
}


class Sale
{
	public string town {
		get;
		set;
	}

	public string product {
		get;
		set;
	}

	public decimal price {
		get;
		set;
	}

	public decimal quantity {
		get;
		set;
	}


	public static Sale ReadSale(){
		string[] input = Console.ReadLine ().Split (' ');
		Sale curr = new Sale ();
		curr.town = input [0];
		curr.product = input [1];
		curr.price = decimal.Parse (input [2]);
		curr.quantity = decimal.Parse (input [3]);

		return curr;
	}


}
