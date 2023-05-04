using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Guess
    {
		private int userInput;
		private int tries;
		private int randNum;
		private int losses;
		private int wins;
		private int gamesPlayed;
		private Boolean check;

		public Guess()
		{
			var randomNumber = new Random();
			randNum = randomNumber.Next(0, 100);
			tries = 10;
			wins = 0;
			losses = 0;
			gamesPlayed = 0;
		}
		public int UserInput
		{
			get{ 
				return userInput;
			}
			set{ this.userInput = value; }
		}
		public int Tries
		{
			get{ 
				return tries; 
			}
		}
		public int RandomNum
		{
			get
			{
				return randNum;
			}
		}
		public int Wins
		{
			get { 
				return wins; 
			}
		}
		public int Losses
		{
			get { 
				return losses; 
			}
		}
		public int GamesPlayed
		{
			get {
				return gamesPlayed;
			}
		}
		public Boolean Check()
        {
			check = false;
			if (userInput == randNum)
			{
				wins = wins + 1;
				gamesPlayed = gamesPlayed + 1;
				check = true;
				tries = 11;
				var randomNumber = new Random();
				randNum = randomNumber.Next(0, 100);
			}
			else if (userInput != randNum && tries == 1)
			{
				losses = losses + 1;
				gamesPlayed = gamesPlayed + 1;
				tries = 11;
				var randomNumber = new Random();
				randNum = randomNumber.Next(0, 100);
			}
			tries = tries - 1;
			return check;
				
        }
		public String Compare()
        {
			if(userInput < randNum)
            {
				return "low";
            }
            else
            {
				return "high";
            }
        }
	}

}
