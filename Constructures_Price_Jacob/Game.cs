using System;

namespace Constructures_Price_Jacob
{
	public class Game
	{
		//intializes 2 fields for the Game class, title a genere
		public string title;
		public string genre;


		//creates a costructure for the game class taking two arguments
		public Game(string title = "unknown", string genre = "casual")
		{
			this.title = title;
			this.genre = genre;
		}

		
	}
}
