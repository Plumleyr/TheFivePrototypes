using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFivePrototypes
{
    class Card(Colors color, Ranks rank)
    {
        public Colors CardColor { get; init; } = color;
        public Ranks CardRank { get; init; } = rank;

        public string NumOrSymbol => (int)CardRank > 10 ? "Symbol" : "Number";

        public void PrintCardName()
        {
            Console.WriteLine($"The {this.CardColor} {this.CardRank}");
        }

        static public Card[] DeckOfCards()
        {
            Card[] cardArray = new Card[56];
            int cardCount = 0;

            var colorsArray = Enum.GetValues(typeof(Colors));
            var ranksArray = Enum.GetValues(typeof(Ranks));

            foreach (Colors color in colorsArray)
            {
                foreach (Ranks rank in ranksArray)
                {
                    cardArray[cardCount++] = new Card(color, rank);
                }
            }

            return cardArray;
        }
    }

    enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow
    }

    enum Ranks
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        DollarSign,
        Percent,
        Caret,
        Ampersand
    }
}
