using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blackJake.Classes
{
    class Deck
    {
        public List<Card> Cards { get; set; }
        public Random Randomizer { get; set; }
        public Card GetRandomCard()
        {
            Card cardToRetern = this.Cards[Randomizer.Next(0, this.Cards.Count)];
            this.Cards.Remove(cardToRetern);
            return cardToRetern;
        }
        public Deck()
        {
            Card crd1 = new Card(1, "Spade", 2, "2");
            Card crd2 = new Card(2, "Spade", 3, "3");
            Card crd3 = new Card(3, "Spade", 4, "4");
            Card crd4 = new Card(4, "Spade", 5, "5");
            Card crd5 = new Card(5, "Spade", 6, "6");
            Card crd6 = new Card(6, "Spade", 7, "7");
            Card crd7 = new Card(7, "Spade", 8, "8");
            Card crd8 = new Card(8, "Spade", 9, "9");
            Card crd9 = new Card(9, "Spade", 10, "10");
            Card crd10 = new Card(10, "Spade", 10, "Jack");
            Card crd11 = new Card(11, "Spade", 10, "Queen");
            Card crd12 = new Card(12, "Spade", 10, "King");
            Card crd13 = new Card(13, "Spade", 1, "Ace");

            this.Cards = new List<Card> { crd1, crd2, crd3, crd4, crd5, crd6, crd7, crd8, crd9, crd10, crd11, crd12, crd13 };
            this.Randomizer = new Random();
        },
    
        {
            Card crd1 = new Card(1, "Club", 2, "2");
            Card crd2 = new Card(2, "Club", 3, "3");
            Card crd3 = new Card(3, "Club", 4, "4");
            Card crd4 = new Card(4, "Club", 5, "5");
            Card crd5 = new Card(5, "Club", 6, "6");
            Card crd6 = new Card(6, "Club", 7, "7");
            Card crd7 = new Card(7, "Club", 8, "8");
            Card crd8 = new Card(8, "Club", 9, "9");
            Card crd9 = new Card(9, "Club", 10, "10");
            Card crd10 = new Card(10, "Club", 10, "Jack");
            Card crd11 = new Card(11, "Club", 10, "Queen");
            Card crd12 = new Card(12, "Club", 10, "King");
            Card crd13 = new Card(13, "Club", 1, "Ace");

            this.Cards = new List<Card> { crd1, crd2, crd3, crd4, crd5, crd6, crd7, crd8, crd9, crd10, crd11, crd12, crd13 };
            this.Randomizer = new Random();
        },
     public Deck()
        {
            Card crd1 = new Card(1, "Heart", 2, "2");
            Card crd2 = new Card(2, "Heart", 3, "3");
            Card crd3 = new Card(3, "Heart", 4, "4");
            Card crd4 = new Card(4, "Heart", 5, "5");
            Card crd5 = new Card(5, "Heart", 6, "6");
            Card crd6 = new Card(6, "Heart", 7, "7");
            Card crd7 = new Card(7, "Heart", 8, "8");
            Card crd8 = new Card(8, "Heart", 9, "9");
            Card crd9 = new Card(9, "Heart", 10, "10");
            Card crd10 = new Card(10, "Heart", 10, "Jack");
            Card crd11 = new Card(11, "Heart", 10, "Queen");
            Card crd12 = new Card(12, "Heart", 10, "King");
            Card crd13 = new Card(13, "Heart", 1, "Ace");

            this.Cards = new List<Card> { crd1, crd2, crd3, crd4, crd5, crd6, crd7, crd8, crd9, crd10, crd11, crd12, crd13 };
            this.Randomizer = new Random();
        }
    public Deck()
        {
            Card crd1 = new Card(1, "Diamond", 2, "2");
            Card crd2 = new Card(2, "Diamond", 3, "3");
            Card crd3 = new Card(3, "Diamond", 4, "4");
            Card crd4 = new Card(4, "Diamond", 5, "5");
            Card crd5 = new Card(5, "Diamond", 6, "6");
            Card crd6 = new Card(6, "Diamond", 7, "7");
            Card crd7 = new Card(7, "Diamond", 8, "8");
            Card crd8 = new Card(8, "Diamond", 9, "9");
            Card crd9 = new Card(9, "Diamond", 10, "10");
            Card crd10 = new Card(10, "Diamond", 10, "Jack");
            Card crd11 = new Card(11, "Diamond", 10, "Queen");
            Card crd12 = new Card(12, "Diamond", 10, "King");
            Card crd13 = new Card(13, "Diamond", 1, "Ace");

            this.Cards = new List<Card> { crd1, crd2, crd3, crd4, crd5, crd6, crd7, crd8, crd9, crd10, crd11, crd12, crd13 };
            this.Randomizer = new Random();
        }
        

    }
}
