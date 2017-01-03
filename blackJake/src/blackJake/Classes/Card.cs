using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blackJake.Classes
{
    class Card
    {
        public int Id { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        public string Rank { get; set; }
        public Card(int id, string suit, int value, string rank)
        { 
            this.Id = Id;
            this.Suit = suit;
            this.Value = Value;
            this.Rank = rank;
        }

    }
}


       







