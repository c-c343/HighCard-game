using HighCard;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;
namespace HighCard
{
	class Card
	{
		//Gave values to each suit for better management
		public enum SUIT
        {
			hearts = 1,
			spades = 2,
			diamonds = 3,
			clubs = 4
        }
		//Gave values to each face for better management
		public enum VALUE
        {
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			Six = 6,
			Seven = 7,
			Eight = 8,
			Nine = 9, 
			Ten = 10,
			Jack = 11,
			Queen = 12,
			King = 13,
			Ace = 14
		}
		int iCard, iSuit;
		public Card (int cardIndex, int suitIndex)
        {
			iCard = cardIndex;
			iSuit = suitIndex;
        }

		public int getCard()
        {
			return iCard;
        }
		public int getSuit()
        {
			return iSuit;
        }
		public override string ToString()
		{
			//return face string, add an "of"
			//ex: "king of Diamonds"
			//used from piseth Chhourm YouTube video tutorial
			return (VALUE)iCard + " of " + (SUIT)iSuit;
		}

		
	}
}