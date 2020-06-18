using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server
{
    public class Deck
    {
        public Deck()
        {
            List<string> ranks = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
            List<string> suits = new List<string> { "s", "d", "c", "h" };
            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    Cards.Add(rank + suit);
                }
            }
            Shuffle();
        }
        public List<string> Cards { get; set; }

        public void Shuffle()
        {
            var rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = Cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    string value = Cards.ElementAt(k);
                    Cards[k] = Cards[n];
                    Cards[n] = value;
                }
            }
        }
        public string Deal()
        {
            string value = Cards.First();
            Cards.RemoveAt(Cards.Count - 1);
            return value;
        }
    }
}
