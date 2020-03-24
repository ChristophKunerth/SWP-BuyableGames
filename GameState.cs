using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    // Defines Methods for the various Operations you can do to a game.
    //Bools track the ownership status
    public abstract class GameState
    {
        protected Game _game;
        protected bool _isOwned;
        protected bool _isInstalled;
        protected bool _isPlaying;

        public Game Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public abstract void BuyGame();
        public abstract void InstallGame();
        public abstract void DeleteGame();
        public abstract void StartGame();
    }
}
