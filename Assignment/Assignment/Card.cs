using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }
        public Card(int suit2, int cardvalue2)
        {
            Suit = suit2;
            Value = cardvalue2;
        }
        public Card[] Cards
        {
            get
            {
                return Cards;

            }
        }
        public string GetCard
        {
            get{
                return Value + " " + Suit;
            }
        }
    }
}