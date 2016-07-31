using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		bool keepLooping = true;
		List<string[]> allInputs = new List<string[]> ();

		while (keepLooping) {
			string[] input = Console.ReadLine ().Split ('\\');

			switch (input[0]) {

			case "stop":
				keepLooping = false;
				break;

			default:
				input = parseMessedInput (input);
				allInputs.Add (input);
				break;
			}
		}

		SortedDictionary<string, int> CountryCity = new SortedDictionary<string, int> ();
		List<City> cities = new List<City> ();

		foreach (var arr in allInputs) {
			if (!CountryCity.ContainsKey (arr[0])) {
				CountryCity.Add (arr[0], 1);
			}else{
				CountryCity [arr [0]] += 1;
			}

			City temp = new City ();
			temp.name = arr [1];
			temp.population = long.Parse (arr [2]);
			if (!cityExistsInCurrentList (temp, cities)) {
				cities.Add (temp);	
			}else if (cityExistsInCurrentList (temp, cities)) {
				if (newCityPopIsHigher (temp, cities)) {
					cities = refreshPopulation (temp, cities);
				}
			}

		}


		// Print num cities
		foreach (var inp in CountryCity) {
			Console.WriteLine (string.Join (" -> ", inp.Key, inp.Value));
		}
		// Print City and Pop
		List<City> citiesSortedByPop = cities.OrderBy (x => -x.population).Distinct ().ToList ();
		for (int i = 0; i < Math.Min (3, citiesSortedByPop.Count); i++) {
			Console.WriteLine ("{0} -> {1}", citiesSortedByPop[i].name, citiesSortedByPop[i].population);
		}



	}

	public static string[] parseMessedInput(string[] arr){
		string[] cleanWords = new string[arr.Length];
		for (int i = 0; i< arr.Length; i++) {
			char[] letters = arr[i].ToCharArray ();
			for (int j = 0; j < letters.Length; j++) {
				if (char.IsLetter (letters[j]) ) {
					cleanWords[i] = cleanWords[i] + letters [j].ToString ();
				}else if (i>1 && char.IsDigit (letters[j])) {
					cleanWords[i] = cleanWords[i] + letters [j].ToString ();
				}
			}
		}
		cleanWords = orderMessedInput (cleanWords);

		return cleanWords;
	}


	public static string[] orderMessedInput(string[] arr){
		
		if (char.IsLower (arr[0][0])) {
			string temp = arr [0];
			arr [0] = arr [1];
			arr [1] = temp;
		}

		return arr;
	}

	public static bool cityExistsInCurrentList(City tocheck, List<City> cities){
		bool exists = false;
		foreach (var c in cities) {
			if (c.name==tocheck.name) {
				exists = true;
			}
		}
		return exists;
	}

	public static bool newCityPopIsHigher(City tocheck, List<City> cities){
		long currPop = tocheck.population;
		bool higher = false;
		foreach (var c in cities) {
			if (currPop>c.population) {
				higher = true;
			}
		}
		return higher;
	}


	public static List<City> refreshPopulation(City tocheck, List<City> cities){
		long pop = tocheck.population;
		for (int i = 0; i < cities.Count; i++) {
			if (tocheck.name == cities[i].name) {
				cities [i].population = pop;
			}
		}
		return cities;
	}
}




class City
{
	public string name {
		get;
		set;
	}
	public long population {
		get;
		set;
	}
}














