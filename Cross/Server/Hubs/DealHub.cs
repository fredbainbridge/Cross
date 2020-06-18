using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Cross.Server.Hubs
{
    public class DealHub : Hub
    {
        public async Task DealMessage()
        {
            var cards = new List<int>();
            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(rand.Next());
            }
            await Clients.All.SendAsync("ReceiveBoard", cards);
        }
    }
}