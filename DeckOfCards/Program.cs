using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Deck Of Cards!");
            Cards cards = new Cards();
            cards.CardsCreator();

        }
    }
}