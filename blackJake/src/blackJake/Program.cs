using blackJake.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blackJake
{
    public class Program
    {
        private static IEnumerable<string> suit;

        public static void Main(string[] args)
        {
            //Grossness for creating 13 cards-------------
            
            // Instance of Deck

            Deck deck = new Deck();
            int value;

            foreach (string Suit in suit)
            {
                foreach (string Id in id)
                {
                    value = Int32.TryParse(Id, out value) ? value : Id == "A" ? 1 : 11;
                    deck.push(new Card(id, suit, value));
                }
                return deck;
            }

            //Adding Cards to Deck.Cards in the worst way possible..........
      
          //  Card cardFormDeck = deck.GetRandomCard();

            //Deal a random card from the dack
            Dealer dealer = new Dealer();
            Player player = new Player();

            //Deal cards to players
            for(int i = 0; i<2; i++)
            {
                player.Hand.Add(dealer.DealCard(deck));
                dealer.Hand.Add(dealer.DealCard(deck));
            }
            Console.WriteLine("PLYEARES CARDS");
            foreach(Card card in player.Hand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
            }
            Console.WriteLine("Dealer Cards");
            foreach(Card card in dealer.Hand)
            {
                Console.WriteLine("{0} of {1}", card.Rank, card.Suit);
                
            }

            Console.WriteLine("------------------------------");
            //Check that the random card methiod worked 
            Console.ReadLine();
           
        }

    }
}
