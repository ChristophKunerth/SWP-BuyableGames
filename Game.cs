using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    //Games track their State and allow for the State Methods. Error handling is done in the latter.
    public class Game
    {
        private GameState _state;
        private String _name;

        public Game(string name)
        {
            _name = name;
            _state = new UnownedGame(this);
        }

        public String Name
        {
            get { return _name; }
        }

        public GameState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void BuyGame()
        {
            _state.BuyGame();
        }

        public void InstallGame()
        {
            _state.InstallGame();
        }

        public void DeleteGame()
        {
            _state.DeleteGame();
        }

        public void StartGame()
        {
            _state.StartGame();
        }
    }
}
