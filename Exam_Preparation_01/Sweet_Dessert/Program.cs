using System;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		decimal cash = decimal.Parse (Console.ReadLine ());
		long numGuests = long.Parse (Console.ReadLine ());
		decimal singleBananaPrice = decimal.Parse (Console.ReadLine ());
		decimal singleEggPrice = decimal.Parse (Console.ReadLine ());
		decimal kiloBerriesPrice = decimal.Parse (Console.ReadLine ());

		// Cook food in lots of 6
		// 2 bananas, 4 eggs and 0.2kg of berries PER LOT

		// Is the cash enough to buy products to cook for all the guests

		decimal singleLotPrice = (decimal)2.0 * singleBananaPrice + (decimal)4.0 * singleEggPrice + (decimal)0.2 * kiloBerriesPrice;

		// find number of lots needed

		long checkForRemainder = numGuests % 6;
		long numLots = numGuests / 6;
		if (checkForRemainder>0) {
			numLots += 1;
		}

		// find cash needed

		decimal cashNeeded = (decimal)numLots * singleLotPrice;

		if (cashNeeded<= cash) {
			Console.WriteLine ("Ivancho has enough money - it would cost {0:f2}lv.", cashNeeded);
		}else{
			Console.WriteLine ("Ivancho will have to withdraw money - he will need {0:f2}lv more.", cashNeeded - cash);
		}



	}
}




