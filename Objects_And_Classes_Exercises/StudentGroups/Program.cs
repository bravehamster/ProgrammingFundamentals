using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		List<Town> a = ReadTownsAndStudents ();
		List<Group> b = DistributeStudentsIntoGroups (a);


		Console.WriteLine ("Created {0} groups in {1} towns:", b.Count, a.Count);
		foreach (var grp in b) {
			Console.WriteLine ("{0}=> {1}", grp.Town.name, string.Join (", ", grp.Students.Select ((x, idx) => x = grp.Students[idx]).Select (x=>x.email). ToList ()));
		}
	}

	static List<Town> ReadTownsAndStudents(){
		List<Town> towns = new List<Town>();

		int i = -1;
		bool keepLooping = true;
		while (keepLooping == true) {
			string inputLine = Console.ReadLine ();



			if (inputLine.Contains ("=>")) {
				Town temp = new Town ();
				char[] split = new char[]{ '=' };
				string[] elements = inputLine.Split (split, StringSplitOptions.RemoveEmptyEntries);
				string[] secElem = elements [1].Split (' ');
				temp.name = elements [0];
				temp.seatsCount = int.Parse (secElem [1]);
				temp.Students = new List<Student>();
				towns.Add (temp);
				i++;
			}else if(inputLine.Contains ("|")){
				Student temp = new Student ();
				char[] split = new char[]{ '|' };
				string[] elements = inputLine.Split (split, StringSplitOptions.RemoveEmptyEntries);
				temp.name = elements [0].Trim ();
				temp.email = elements [1].Trim ();
				string date = elements [2].Trim ();
				string[] checkDate = date.Split ('-');
				if (checkDate[0].Length == 1) {
					date = "0" + date;
				}
				temp.registrationDate = DateTime.ParseExact( date, "dd-MMM-yyyy", CultureInfo.InvariantCulture);
				towns[i].Students.Add (temp);

			}else {
				keepLooping = false;
			}
	
		}
		return towns;
	}

	static List<Group> DistributeStudentsIntoGroups(List<Town> towns){
		var groups = new List<Group>();

		List<Town> sortedTowns = towns.OrderBy (x => x.name).ToList ();

		foreach (var t in sortedTowns) {
			IEnumerable<Student> students = t.Students.OrderBy (x => x.registrationDate).ThenBy (x => x.name).ThenBy (x => x.email);

			while (students.Any ()) {

				var tempgrp = new Group ();
				tempgrp.Town = t;
				tempgrp.Students = students.Take (tempgrp.Town.seatsCount).ToList ();
				students = students.Skip (tempgrp.Town.seatsCount);
				groups.Add (tempgrp);	
			}


		}


		return groups;
	}


}

class Student
{
	public string name {
		get;
		set;
	}
	public string email {
		get;
		set;
	}

	public DateTime registrationDate {
		get;
		set;
	}

}


class Town
{
	public string name {
		get;
		set;
	}
	public int seatsCount {
		get;
		set;
	}
	public List<Student> Students {
		get;
		set;
	}
}

class Group
{
	public Town Town {
		get;
		set;
	}

	public List<Student> Students {
		get;
		set;
	}
}








