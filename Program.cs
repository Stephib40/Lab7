using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Console.WriteLine("Welcome to our C# class");
				Console.WriteLine("Which student would you like to learn more about? (enter a number 0-13)");
				int input = int.Parse(Console.ReadLine());
				if (input > 13)
				{
					Console.WriteLine("Your number is greater than 13 and will not work");
				}
				//need a code here for if someone does outside of 0-13
				//holy crap I did it! 
				else
				{
				List<string> studentName = new List<string>();
				studentName.Add("Tommy");
				studentName.Add("Kelsey");
				studentName.Add("Steph");
				studentName.Add("Arianna");
				studentName.Add("Megan");
				studentName.Add("Jillane");
				studentName.Add("Diane");
				studentName.Add("JJ");
				studentName.Add("Christopher");
				studentName.Add("Doreen");
				studentName.Add("Ryan");
				studentName.Add("Sabrina");
				studentName.Add("Josh");
				studentName.Add("Tori");

				List<string> homeTown = new List<string>();
				homeTown.Add("Raliegh");
				homeTown.Add("Grand Rapids");
				homeTown.Add("Highland");
				homeTown.Add("Hotlanta");
				homeTown.Add("Megan");
				homeTown.Add("Rockford");
				homeTown.Add("Warren");
				homeTown.Add("Lake Orion");
				homeTown.Add("Cincinatti");
				homeTown.Add("San Diego");
				homeTown.Add("Chicago");
				homeTown.Add("St. Joseph");
				homeTown.Add("Alaska");
				homeTown.Add("Marne");

				List<string> favFood = new List<string>();
				favFood.Add("Curry & Olives");
				favFood.Add("Pickles");
				favFood.Add("Seafood");
				favFood.Add("Everything");
				favFood.Add("Salad");
				favFood.Add("Sushi");
				favFood.Add("Italin");
				favFood.Add("Strawberries");
				favFood.Add("Tofu");
				favFood.Add("Tacos");
				favFood.Add("BBQ");
				favFood.Add("Wings");
				favFood.Add("Shwarma");
				favFood.Add("Chocolate");


				string n = studentName[input];
				Console.WriteLine("Student " + (input) + " is " + (n));
				Console.WriteLine("What would you like to know about " + (n) + " Hometown or Favorite Food?");
				string inputTwo = Console.ReadLine();
				//dont forget to accomodate the user using a capital or lowercase here for inputTwo
				string h = homeTown[input];
				string f = favFood[input];

					if ((inputTwo == "hometown") || (inputTwo == "Hometown"))
					{
						Console.WriteLine(h);
					}
					else if ((inputTwo == "favorite food") || (inputTwo == "Favorite Food"))
					{
						Console.WriteLine(f);
					}
				}
			}


			while (Continue() == true);

			}
			public static Boolean Continue()
			{
				Boolean run;
				Console.WriteLine("Continue: y/n?");
				string answer = Console.ReadLine();

				if ((answer == "Y") || (answer == "y"))
				{
					run = true;
				}
				else if ((answer == "N") || (answer == "n"))
				{
					run = false;
					Console.WriteLine("Later.");
				}
				else
				{
					Console.WriteLine("Yadda Yadda");
					run = Continue();
				}
				return run;

			

			}
	}
}
