﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class GameEventManager
    {
        public delegate void GameEvent();

        public static GameEvent OnGameStart, OnGameOver;

        // a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            if (OnGameStart != null)
            {
                //print message
                Console.WriteLine("The game has started...");
                OnGameStart();
            }
        }

        // static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game has stopped...");
                OnGameOver();
            }
        }
    }
}
