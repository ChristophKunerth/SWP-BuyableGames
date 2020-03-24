using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    class StartedGame : GameState
    {
        public StartedGame(GameState state) : this(state.Game) { }
        public StartedGame(Game game)
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
            Console.WriteLine("Please exit the game first.", _game.Name);
        }

        public override void InstallGame()
        {
            Console.WriteLine("{0} is already installed.", _game.Name);
        }

        public override void StartGame()
        {
            Console.WriteLine("{0} is running already.", _game.Name);
        }

        private void Initialize()
        {
            _isOwned = true;
            _isInstalled = true;
            _isPlaying = true;
        }
    }
}
