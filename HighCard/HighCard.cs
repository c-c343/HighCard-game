using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;


/*
 * Simple card game. 
 * At the beginning of the game, two players are created: player 1, player 2
 * Introductory menu appears and asks for user input
 * as long as user input is = Y || y, the game will continue to deal cards to player 1 and player 2
 * as well as finding a winner for each game
 * When user enters N || n || any other key, game terminates.
 * 
 * 
*/
namespace HighCard
{
    public class program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            //-------------------------CONSOLE INTRODUCTION--------------------------//
            Console.WriteLine("***************************************\n");
            Console.WriteLine("\t Hello, Welcome !\n");
            Console.WriteLine("\t This game is called 'High Card'\n");
            Console.WriteLine("\t I will distribute one card to player number 1 and player number 2\n");
            Console.WriteLine("\t The player with the highest card number will be the winner! \n\n");
            Console.WriteLine("\t Let's Begin.....\n");
            Console.WriteLine("Press any key to start...\n");
            Console.WriteLine("***************************************\n");

            //-----------------------------------------------------------------------//

            //creating deck
            Deck deck = new Deck();
            deck.Shuffle();




            //---------------------------Deal Cards--------------------------------//
            
            Console.WriteLine("Continue? [Y/N]: ");
            string choice = Console.ReadLine();
            do
            {
                //deal cards
                Card player1Card = deck.Deal();
                Card player2Card = deck.Deal();


                //displays card given to each player
                Console.WriteLine(player1 + ": " + player1Card + "\n" + player2 + ": " + player2Card + "\n");

                //if both players get the same number, check the suit
                if (player1Card.getCard() == player2Card.getSuit())
                {
                    if (player1Card.getSuit() > player2Card.getSuit())
                    {
                        Console.WriteLine("Player 1 wins\n");
                    }
                    else
                        Console.WriteLine("Player 2 wins!\n");
                }
                //continue
                else
                {
                    if (player1Card.getCard() > player2Card.getCard())
                    {
                        Console.WriteLine("Player 1 wins\n");
                    }
                    else
                        Console.WriteLine("Player 2 Wins!\n");
                }

                //Check for user input
                Console.WriteLine("Continue? [Y/N]: ");
                choice = Console.ReadLine();
            } while (choice == "Y" || choice == "y");

            //program terminates after user enters N or anything other than Y.

        }

    }
}
