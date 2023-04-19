using System;

namespace Constructures_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            // intializes two game objects, 1 with arguments and 1 without
            Game game1 = new Game("Devil May Cry V", "Action Hack N Slash");
            Game game2 = new Game();


            //writes the title and genere of the default game
            Console.WriteLine(game2.title);
            Console.WriteLine(game2.genre);

        }
    }
}
