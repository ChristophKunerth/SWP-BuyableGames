using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    class UnownedGame : GameState
    {
        public UnownedGame(GameState state) : this(state.Game) { }
        public UnownedGame(Game game)
        {
            this._game = game;
            Initialize();
        }

        public override void BuyGame()
        {
            Console.WriteLine("You have bought {0}! It can now be installed.", _game.Name);
            _game.State = new BoughtGame(this);
        }

        public override void DeleteGame()
        {
            Console.WriteLine("You cannot delete {0} because you do not own it.", _game.Name);
        }

        public override void InstallGame()
        {
            Console.WriteLine("You cannot install {0} because you do not own it.", _game.Name);
        }

        public override void StartGame()
        {
            Console.WriteLine("You do not own {0}.", _game.Name);
        }

        private void Initialize()
        {
            _isOwned = false;
            _isInstalled = false;
            _isPlaying = false;
        }
    }
}
