using System;

namespace HighCard
{
    public class program
    {
        static void Main(string[] args)
        {
            //-------------------------CONSOLE INTRODUCTION--------------------------//
            Console.WriteLine("***************************************\n");
            Console.WriteLine("\t Hello, Welcome !\n");
            Console.WriteLine("\t This game is called 'High Card'\n");
            Console.WriteLine("\t I will distribute one card to player number 1 and player number 2\n");
            Console.WriteLine("\t The player with the highest card number will be the winner! \n\n");
            Console.WriteLine("\t Let's Begin.....\n");
            Console.WriteLine("Press any key to start...\n");
            Console.WriteLine("***************************************\n");
            Console.ReadKey();
            Console.WriteLine("\n");
            //-----------------------------------------------------------------------//
            // Console.WriteLine("displaying a card value: " + (int)CardVals.Two);
            //creating variable for player 1 card, then deal
            Card p1Card;
            Deck deck = new Deck();
            deck.Shuffle();
            p1Card = deck.Deal();

            Console.WriteLine("Player 1: ");
            Console.WriteLine(p1Card);

            //creating variable for player 2 card without resetting deck. deal card.
            Card p2Card;
            p2Card = deck.Deal();
            Console.WriteLine("Player 2: ");
            Console.WriteLine(p2Card);



            /*for (int i = 0; i < 52; i++)
            {
                //output every card created
                Console.Write(" {0, -19} ", deck.Deal());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();*/



            /*        if (p1Card.Value > p2Card.Value)
                    {
                        Console.WriteLine("\nPlayer 1 Wins! \n");
                    }
                    else if (p2Card.Value > p1Card.Value)
                    {
                        Console.WriteLine("Player 2 Wins!");
                    }
                    else
                        Console.WriteLine("It's a tie!");
                }*/

        }

    }
}
