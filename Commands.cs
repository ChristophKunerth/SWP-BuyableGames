using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    // Commands here, implementing ICommand for the Command Pattern :) 
    // They basically just call the Method of the Game, as the Error handling is implemented in the States from the earlier Exercise anyway.
    public class BuyCommand : ICommand
    {
        private Game _game;
        public BuyCommand(Game game) 
        {
            _game = game;
        }

        public void Execute()
        {
            _game.BuyGame();
        }
    }

    public class InstallCommand : ICommand
    {
        private Game _game;
        public InstallCommand(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.InstallGame();
        }
    }

    public class DeleteCommand : ICommand
    {
        private Game _game;
        public DeleteCommand(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.DeleteGame();
        }
    }

    public class PlayCommand : ICommand
    {
        private Game _game;
        public PlayCommand(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.StartGame();
        }
    }

    // Composite Command "OneClickPlay" allows for one Execution Method to Buy, Install, AND Start a game.
    // If the Game is already owned, buying will be skipped, as is the case for when it's already installed
    public class OneClickPlay : CompositeCommand
    {
        private Game _game;
        public OneClickPlay(Game game)
        {
            _game = game;

            if (_game.State.GetType() == typeof(UnownedGame))
            {
                AddChild(new BuyCommand(_game));
                AddChild(new InstallCommand(_game));
                AddChild(new PlayCommand(_game));
            }
            else if (_game.State.GetType() == typeof(BoughtGame))
            {
                AddChild(new InstallCommand(_game));
                AddChild(new PlayCommand(_game));
            }
            else if (_game.State.GetType() == typeof(InstalledGame))
            {
                AddChild(new PlayCommand(_game));
            }
            else
            {
                Console.WriteLine("The Game is already running. Nothing happens.");
            }
        }
    }
}
