using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blackJake.Classes
{
    class Dealer
    {
        public List<Card> Hand { get; set; }
        public Card DealCard(Deck deck)
        {
            return deck.GetRandomCard();
        }
        
        public Dealer()
        {
            this.Hand = new List<Card>();
        }
    }
}
