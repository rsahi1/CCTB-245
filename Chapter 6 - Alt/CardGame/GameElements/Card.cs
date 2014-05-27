﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    // Extra data types that relate to the card class
    enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }
    enum CardFace
    {
        Ace = 1,
        Deuce,
        Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
    }

    class Card
    {
        public Suit Suit { get; private set; }
        public CardFace Face { get; private set; }
        public int FaceValue
        {
            get
            {
                int value = (int)Face; // one valid use of casting....
                if (value > 10)
                    value = 10; // Jack, Queen, and King
                return value;
            }

        }
        // TODO : Create a constructor that take two parameters: a Suit and a CardFace
    }
}
