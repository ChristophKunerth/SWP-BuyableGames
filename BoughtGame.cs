using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    class BoughtGame : GameState
    {
        public BoughtGame(GameState state) : this(state.Game) { }
        public BoughtGame(Game game)
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
            Console.WriteLine("You cannot delete {0} because it is not installed.", _game.Name);
        }

        public override void InstallGame()
        {
            Console.WriteLine("You installed {0}! It can now be played.", _game.Name);
            _game.State = new InstalledGame(this);
        }

        public override void StartGame()
        {
            Console.WriteLine("You do not have {0} installed.", _game.Name);
        }

        private void Initialize()
        {
            _isOwned = true;
            _isInstalled = false;
            _isPlaying = false;
        }
    }
}
