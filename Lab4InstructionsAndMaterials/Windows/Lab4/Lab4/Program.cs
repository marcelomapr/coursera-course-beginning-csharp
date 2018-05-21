using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Implements Lab 4 functionality
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Lab 4 functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // create a new deck and print the contents of the deck
            Deck deck = new Deck();
            deck.Print();

            Console.WriteLine();

            Console.WriteLine("Deck embaralhado:");

            // shuffle the deck and print the contents of the deck
            deck.Shuffle();
            deck.Print();

            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Card card = deck.TakeTopCard();
            Console.WriteLine("Drawn Card: " + card.Rank + " of " + card.Suit, ".");

            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Card card2 = deck.TakeTopCard();
            Console.WriteLine("Drawn Card: " + card2.Rank + " of " + card2.Suit + ".");

            Console.WriteLine();
        }
    }
}
