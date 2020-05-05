using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameofWar
{
    class Player
    {
        public string name { get; set; }
        public List<Card> deck { get; set; }

        public Player()
        {

        }
        public List<Card> Deal(List<Card> cards)
        {
            List<Card> playerDeck = new List<Card>();
            List<Card> player2Deck = new List<Card>();

            int counter = 2;

            foreach (var card in cards)
            {
                if(counter%2 == 0)
                {
                    player2Deck.Add(card);
                }
                else
                {
                    playerDeck.Add(card);
                }

                counter++;
            }

            deck = playerDeck;
            return player2Deck;
        }
    }
}
