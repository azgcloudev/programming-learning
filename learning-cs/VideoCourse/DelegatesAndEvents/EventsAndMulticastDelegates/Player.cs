using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class Player
    {
        // name
        public string PlayerName { get; set; }
        
        public Player(string name)
        {
            this.PlayerName = name;

            // subscribe to eventmanager
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

        }

        private void StartGame()
        {
            Console.WriteLine($"Spawing Player with ID : {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
