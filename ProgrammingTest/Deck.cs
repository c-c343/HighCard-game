using System;
using System.Security.Cryptography.X509Certificates;

public class Deck
{
	private Card[] deck;
	private int currCard;
	private const int NUMCARDS = 52;
	//random number generator to shuffle cards
	private Random ranNum;

	public Deck()
	{
		//populate deck
		string[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", 
							"Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
		string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
		deck = new Card[NUMCARDS];

		currCard = 0;
		//store new random number in ranNum
		ranNum = new Random();

		//Creating deck of cards
		for (int i = 0; i< deck.Length; i++) {
			//set deck location(0) with a new card. "faces" return the remainder of the count
			//divided by 11 ( to process all the faces) and suits with a count divided by 13 (so 
			//we won't have a remainder.
			deck[i] = new Card(faces[i % 11], suits[i / 13]);		
		}

	}
	public void Shuffle()
	{
		currCard = 0;
		for (int first = 0; first < deck.Length; first++)
		{
			int second = ranNum.Next(NUMCARDS);
			Card temp = deck[first];
			deck[first] = deck[second];
			deck[second] = temp;

		}

	}
	public Card Deal()
    {
		if (currCard < deck.Length)
			return deck[currCard++];
		else
			return null;
    }
}
