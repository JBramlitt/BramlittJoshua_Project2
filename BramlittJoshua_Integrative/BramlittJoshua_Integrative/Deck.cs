using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Integrative
{
    class Deck
    {
        private static Random rnd = new Random();
        public List<Card> Cards { get; set; }

        public Deck()
        {   
        }

        public void Shuffle()
        {
            for (int i = Cards.Count - 1; i > 0 ; i--)
            {
                Card temp = Cards[i];

                int index = rnd.Next(0, i + 1);
                Cards[i] = Cards[index];
                Cards[index] = temp;
            }
        }

        public Card Deal()
        {
            Card dealtCard = Cards[0];
            Cards.RemoveAt(0);

            return dealtCard;
        }

        public void CreateCards()
        {
            //string[] tempSuit = { "Diamonds", "Hearts", "Spades", "Clubs" };

            //for (int i = 0; i < 51; i++)
            //{
            //    Card card = new Card(i % 13, tempSuit[i % 4]);
            //    Console.WriteLine(card.Suit + " " + card.Value);
            //    Cards.Add(card);
            //}
            string[] suit = { "Hearts", "Clubs", "Diamonds", "Spades" };
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards.Add(new Card(suit[i % 4], j));
                }
            }

            //for (int i = 0; i < 52; i++)
            //{
            //    Cards.Add(new Card("heart", i % 13));
            //}
        }

    }
}
