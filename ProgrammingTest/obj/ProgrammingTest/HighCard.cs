using System;

namespace HighCard
{
    class HighCard
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                //output every card created
                Console.Write("{0, -19}", deck.Deal());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
