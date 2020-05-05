using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameofWar
{
    class Deck
    {
        public Deck()
        {
            List<Card> deck = new List<Card>();
        }

        public static List<Card> CreateCards()
        {
            List<string> suits = new List<string>();
            suits.Add("D");
            suits.Add("S");
            suits.Add("H");
            suits.Add("C");

            List<Card> cardPile = new List<Card>();
            
            for (int i = 2; i < 14; i++)
            {
                foreach (var name in suits)
                {
                    Card newCard = new Card();
                    newCard.suit = name;
                    newCard.value = i;

                    if (i == 11)
                    {
                        newCard.name = $"{newCard.suit}J";
                    }
                    else if(i == 12)
                    {
                        newCard.name = $"{newCard.suit}Q";
                    }
                    else if(i == 13)
                    {
                        newCard.name = $"{newCard.suit}K";
                    }
                    else if(i == 14)
                    {
                        newCard.name = $"{newCard.suit}A";
                    }
                    else
                    {
                        newCard.name = $"{newCard.suit}{newCard.value}";
                    }

                    cardPile.Add(newCard);
                }
            }

            Shuffle(cardPile);

            return cardPile;
        }
        private static List<Card> Shuffle(List<Card> cardPile)
        {
            Random r = new Random();
            for (int i = cardPile.Count - 1; i > 0; i--)
            {
                int j = r.Next(i + 1);

                Card temp = cardPile[i];
                cardPile[i] = cardPile[j];
                cardPile[j] = temp;
            }

            List<Card> shuffledDeck = new List<Card>();

            foreach (var card in cardPile)
            {
                shuffledDeck.Add(card);
            }

            return shuffledDeck;
        }
        /*private static List<Card> Deal(List<Card> deck)
        {
            List<Card> playerDeck = new List<Card>();
            for (int i = 0; i < deck.Count; i = i +2)
            {
                playerDeck.Add(deck[i]);
            }
            return playerDeck;
        }*/
    }
}
