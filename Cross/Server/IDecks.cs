using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server
{
    public interface IDecks
    {
        Deck GetDeck(int id);
        int AddDeck(Deck deck);
        void SetDeck(int id, Deck deck);
    }
}
