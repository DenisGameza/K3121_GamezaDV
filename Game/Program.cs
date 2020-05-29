using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Game game = new Game(player);
            game.start();
            game.choice();
        }
    }
}
