using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server
{
    public class Decks : IDecks
    {
        private List<Deck> GameDecks { get; set; }
        
        public int AddDeck(Deck deck)
        {
            GameDecks.Add(deck);
            return GameDecks.Count - 1;
        }

        public Deck GetDeck(int id)
        {
            return GameDecks.ElementAt(id);
        }

        public void SetDeck(int id, Deck deck)
        {
            GameDecks[id] = deck;
        }
        
    }
}
