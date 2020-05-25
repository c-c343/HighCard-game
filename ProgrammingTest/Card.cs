using HighCard;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;
namespace HighCard
{
	public class Card
	{
		private string suit;
		private string face;

		private CardVals vals;
		private int currValue;
		public Suits Suit { get; set; }
		//int[] threeHighCard = { 11, 12, 13, 14 }; //Jack, Queen, King, Ace
		public dynamic Value
		{
			get
			{
				if (currValue != 0)
				{
					return currValue;
				}
				else
				{
					return vals;
				}
			}
			set
			{
				if (value > 10)
				{
					vals = value;
					currValue = 0;
				}
				else
				{
					currValue = value;

				}
			}
		}
		public Card(string Face, int value, string Suit)
		{
			face = Face;
			suit = Suit;
			Value = value;
		}
		//want to override every "ToString" function from every class and provide my own definition
		public override string ToString()
		{
			//return face string, add an "of"
			//ex: "king of Diamonds"
			return face + " of " + suit;
			//return $"Card: {this.Value.ToString()} Suit: {this.Suit.ToString()}.";
		}


	}
}