using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    class InstalledGame : GameState
    {
        public InstalledGame(GameState state) : this(state.Game) {}

        public InstalledGame(Game game)
        {
            this._game = game;
            Initialize();
        }

        public override void BuyGame()
        {
            Console.WriteLine("You already own {0}.", _game.Name);
        }

        public override void DeleteGame()
        {
            Console.WriteLine("You uninstalled {0}! It can be reinstalled.", _game.Name);
            _game.State = new BoughtGame(this);
        }

        public override void InstallGame()
        {
            Console.WriteLine("{0} is already installed.", _game.Name);
        }

        public override void StartGame()
        {
            Console.WriteLine("Starting {0}...", _game.Name);
            _game.State = new StartedGame(this);
        }

        private void Initialize()
        {
            _isOwned = true;
            _isInstalled = true;
            _isPlaying = false;
        }


    }
}
