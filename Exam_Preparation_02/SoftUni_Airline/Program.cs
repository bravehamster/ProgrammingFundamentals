using System;

class MainClass
{
	public static void Main (string[] args)
	{

		int n = int.Parse (Console.ReadLine ());
		decimal totalProfit = 0;
		for (int i = 0; i < n; i++) {
			decimal profit = calculateProfit ();
			totalProfit += profit;
		}

		Console.WriteLine ("Overall profit -> {0:f3}$.\nAverage profit -> {1:f3}$.", totalProfit, totalProfit/n);
	}


	public static decimal calculateProfit(){

		long adultPassengers 			= long.Parse (Console.ReadLine ());
		decimal adultTicketPrice 		= decimal.Parse (Console.ReadLine ());
		long youthPassengers 			= long.Parse (Console.ReadLine ());
		decimal youthTicketPrice 		= decimal.Parse (Console.ReadLine ());
		decimal fuelPricePerHour 		= decimal.Parse (Console.ReadLine ());
		decimal fuelConsumptionPerHour 	= decimal.Parse (Console.ReadLine ());
		long flightDuration 			= long.Parse (Console.ReadLine ());


		decimal income = adultPassengers * adultTicketPrice + youthPassengers * youthTicketPrice;
		decimal expenses = fuelPricePerHour * flightDuration * fuelConsumptionPerHour;

		decimal profit = income - expenses;

		if (profit>=0) {
			Console.WriteLine ("You are ahead with {0:f3}$.", profit);
		}else{
			Console.WriteLine ("We've got to sell more tickets! We've lost {0:f3}$.", profit);
		}
		return profit;

	}
}	



