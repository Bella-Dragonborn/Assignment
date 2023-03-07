using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here

            pack = new List<Card>();
            int[] Suits = new int[] { 1, 2, 3, 4 };
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int i = 0;
            foreach (int s in numbers)
            {
                pack.Add(new Card(Suits[0], s));
                i++;

            }
            foreach (int s in numbers)
            {
                pack.Add(new Card(Suits[1], s));
                i++;

            }
            foreach (int s in numbers)
            {
                pack.Add(new Card(Suits[2], s));
                i++;

            }
            foreach (int s in numbers)
            {
                pack.Add(new Card(Suits[3], s));
                i++;
            }

        }

        public void PrintPack()
        {
            for (int i = 0; i < pack.Count; i++)
            {
                Console.WriteLine(pack[i].GetCard);
            }
        }

        public static Card dealCard()
        {
                if (pack.Count > 0)
                {
                    Card card = pack.First();
                    
                    pack.Add(card);
                    pack.RemoveAt(0);
                    return card;
                }
                else return null;
            }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            Random random = new Random();

            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)

            {
                for (int n = 0; n < pack.Count; n++)
                {
                    int m = n + random.Next(52 - n);
                    Card temp = pack[n];
                    pack[n] = pack[m];
                    pack[m] = temp;
                }
                return true;
            }
            if (typeOfShuffle == 2)
            {
                List<Card> tempDeck = new List<Card>();
                for (int i = 0; i < pack.Count; i++)
                {
                    List<Card> right = new List<Card>(pack.Count / 2);
                    List<Card> left = new List<Card>(pack.Count / 2);
                    while (left.Count > 0 && right.Count > 0)
                    {
                        if (random.NextDouble() >= (left.Count / right.Count) / 2)
                        {
                            tempDeck.Add(right.First());
                            right.RemoveAt(0);
                        }
                        else
                        {
                            tempDeck.Add(right.First());
                            left.RemoveAt(0);
                        }
                    }
                    if (left.Count > 0) tempDeck.AddRange(left);
                    if (right.Count > 0) tempDeck.AddRange(right);
                }
                pack = tempDeck;
                return true;
            }
            if (typeOfShuffle == 3)
            {
                Pack NewPack = new Pack();
                return true;
            }
            else return false;
        }

        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List <Card> some = new List<Card>(amount);
            for (int i = 0; i<amount; i++)
            {
                some.Add(pack[i]);

                pack.Add(some[i]);
                pack.RemoveAt(i);
                
            }
            return some;


        }
    }
}