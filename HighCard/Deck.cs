using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace HighCard
{
	internal class Deck
	{
		
		private int currCard;
		private const int NUMCARDS = 52;
		private const int NUMSUITS = 4;
		private const int NUMCARDTYPE = 13;
		//vector used to create a deck of cards. simpler to manage deck
		public List<Card> deck = new List<Card>();
		//random number generator to shuffle cards

		private Random ranNum;

		public Deck()
		{
			//populate deck 
			addCards();

		}
		public List<Card> getDeck()
        {
			return deck;
        }
		//Populate deck
		private void addCards()
        {
			for (int i = 0; i < NUMCARDTYPE; i++)
			{ 
				for (int j = 0; j< NUMSUITS; j++)
                {
					Card iCard = new Card(i, j);
					deck.Add(iCard); //= new Card([i % 11], [j / 13]);
				}
	
				
			}
		}
		//shuffle algorithm found in piseth Chhourm "YouTube"
		public void Shuffle()
		{
			
			//store new random number in ranNum
			ranNum = new Random();
			//shuffle card
			for (int first = 0; first < deck.Count; first++)
			{
				int index = ranNum.Next(first++);
				//storing the next random number into second. Pulls from the deck of 52 cards
				int second = ranNum.Next(NUMCARDS);
				//store first from the deck into temp
				Card temp = deck[index];
				//Store second of the deck into first
				deck[first] = deck[second];
				//then temp into second (swap with second element
				deck[second] = temp;

			}

		}
		public int size()
        {
			return deck.Count;
        }
		public void DeleteCard()
        {
			deck.RemoveAt(0);
        }
		public void Reset()
        {
			deck.Clear();
			addCards();
			Shuffle();
        }
		public Card Deal()
		{
			Card newCard = deck[0];
			DeleteCard();
			return newCard;
		}
		
	}
}