using blackJake.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blackJake
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public Player()
        {
            this.Hand = new List<Card>();
        }

        //first two cards to player
        for (int i = 1; ++i <  2;)
            {
            Player.Hand.Push(MainDeck.pop());
            
            }
    }
}
