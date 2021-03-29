using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards //♥ ♦ ♣ ♠
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Clubs = Cards("Club ♣");
            List<string> Diamonds = Cards("Diamond ♦");
            List<string> Hearts = Cards("Heart ♥");
            List<string> Spades = Cards("Spade ♠");
            
            List<string> deck = Clubs.Concat(Diamonds).Concat(Hearts).Concat(Spades).ToList();
            deck.ForEach(i => Console.WriteLine(i));
        }
        public static List<string>Cards(string symbol)
        {
            List<string>Cards = new List<string>();
            for (int i = 2; i < 11; i++)
            {
                Cards.Add(symbol + " " + i);
            }
            Cards.Add(symbol + " " + "J");
            Cards.Add(symbol + " " + "Q");
            Cards.Add(symbol + " " + "K");
            Cards.Add(symbol + " " + "Ace");
            return Cards;
        }
    }
}