using System;

namespace StateAndCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Game rpg = new Game("Curse of Strahd");
            rpg.BuyGame();
            rpg.InstallGame();
            rpg.DeleteGame();
            rpg.StartGame();*/

            Game rpg = new Game("The Elder Scrolls 7: Revenge of the Todd");
            Game action = new Game("Murder Rampage Killer Man 3: Blood Edition");

            var oneclick = new OneClickPlay(rpg);
            var buy = new BuyCommand(action);
            var install = new InstallCommand(action);
            var delete = new DeleteCommand(action);

            oneclick.Execute();
            buy.Execute();
            install.Execute();
            delete.Execute();
        }
    }
}
