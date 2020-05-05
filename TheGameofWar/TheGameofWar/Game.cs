using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameofWar
{
    class Game
    {
        public Player player { get; set; }
        public Player player2 { get; set; }
        public int turnCount { get; set; }

        public Game(string user, string cpu)
        {
            Player player = new Player();
            player.name = user;
            Player player2 = new Player();
            player.name = cpu;

            var cards = Deck.CreateCards();

            //deal cards to players
            var deck = player.Deal(cards);
        }
        public bool gameOver()
        {
            if (player.deck.Any())
            {
                Console.WriteLine(player.name + "is out of cards." + player2.name + "wins!");
                return true;
            }
            else if (player2.deck.Any())
            {
                Console.WriteLine(player2.name + "is out of cards." + player.name + "wins!");
                return true;
            }
            else if (turnCount > 500)
            {
                Console.WriteLine("It seems that we have reached an impasse. We must fight another day.");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void playTurn()
        {
            List<Card> pile = new List<Card>();

            //Flip card and send to imgBox
            imgBox.src
        }
    }
}
