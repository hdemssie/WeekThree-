using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    //Create an enum to hold suit types
    public enum SUIT
    {
        SPADES = 1,
        CLUBS,
        DIAMONDS,
        HEARTS
    };

    //enum for card names
    public enum NAME
    {
        ACE,
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        highACE
    };

    public class Card
    {


        //card variabeles
        private int value = 0;
        private SUIT suit;
        private NAME name;
        bool isFaceUp = false;
        string location = "Deck";

        //Accessor methods for setting values
        public void SetSuit(SUIT cardSuit)
        {
            suit = cardSuit;
        }

        public void SetName(NAME cardName)
        {
            name = cardName;
        }

        public void SetValue(int cardValue)
        {
            value = cardValue;
        }

        public void SetLocation(string newLocation)
        {
            location = newLocation;
        }

        public void SetFaceUp(bool newFaceUp)
        {
            isFaceUp = newFaceUp;
        }


        //Accessor methods for retrieving values
        public SUIT GetSuit()
        {
            SUIT newSuit = suit;
            return newSuit;
        }

        public NAME GetName()
        {
            NAME newName = name;
            return newName;
        }

        public int GetValue()
        {
            int newValue = value;
            return newValue;
        }

        public string GetLocation()
        {
            return location;
        }

        public bool GetFaceUp()
        {
            return isFaceUp;
        }


        //METHODS
        public void Display()
        {
            Console.WriteLine("{0} of {1}", GetName(), GetSuit(), GetValue());
        }
    }//end Card   
