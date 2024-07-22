using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            // subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

        }
        private void StartGame()
        {
            Console.WriteLine("Audio System Started...");
            Console.WriteLine("Playing Audio...");
        }

        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
