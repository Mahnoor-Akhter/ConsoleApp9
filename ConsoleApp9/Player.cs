using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	public class Player
	{
		public int ID { get; set; }

		public string PlayerName { get; set; }
		public int Score { get;private set; }


		public Player(int id, string playerName , int score)
		{
			ID = id;
			PlayerName = playerName;
			Score = score;
		}
		public void InceraseScore(int valueToAdd)
		{
			if (Score < 100)
				Score += valueToAdd;
		}
	}
}
