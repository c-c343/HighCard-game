using System;

public class Card
{
	private string suit;
	private string face;
	public Card(string Face, string Suit)
	{
		face = Face;
		suit = Suit;
	}

	//want to override every "ToString" function from every class and provide my own definition
	public override string ToString()
	{
		//return face string, add an "of"
		//ex: "king of Diamonds"
		return face + "of" + suit;
	}
}
