using System;
using System.Globalization;
using System.Collections.Generic;

class MainClass
{
	public static void Main (string[] args)
	{
		string startDate = Console.ReadLine ();
		string endDate = Console.ReadLine ();
		DateTime startdate = DateTime.ParseExact (startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
		DateTime enddate = DateTime.ParseExact (endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
		int counter = 0;
		List<DateTime> holidays = new List<DateTime>();

		for (int i = startdate.Year; i <= enddate.Year; i++) {
			holidays.Add (new DateTime (i, 01, 01));
			holidays.Add (new DateTime (i, 03, 03));
			holidays.Add ( new DateTime (i, 05, 01));
			holidays.Add ( new DateTime (i, 05, 06));
			holidays.Add ( new DateTime (i, 05, 24));
			holidays.Add (new DateTime (i, 09, 06));
			holidays.Add ( new DateTime (i, 06, 22));
			holidays.Add ( new DateTime (i, 11, 01));
			holidays.Add ( new DateTime (i, 12, 24));
			holidays.Add ( new DateTime (i, 12, 25));
			holidays.Add ( new DateTime (i, 12, 26));
		}


		for(DateTime date = startdate; date.Date <= enddate.Date; date = date.AddDays(1))
		{
			if (isDateWorkingDay (date, holidays)) {
				counter++;
			}
		}

		Console.WriteLine (counter);
	}



	public static bool isDateWorkingDay(DateTime day, List<DateTime> holidays){
		if (day.DayOfWeek != DayOfWeek.Saturday &&
			day.DayOfWeek != DayOfWeek.Sunday &&
			!isOfficialHoliday (day, holidays)) {
			return true;
		}

		return false;
	}

	public static bool isOfficialHoliday(DateTime day, List<DateTime> holidays){
		for (int i = 0; i < holidays.Count; i++) {			
			if (day == holidays[i]) {
				return true;
			}
		}
		return false;
	}


}

