using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Strings.IntroductionText);
            Console.ReadLine();
            Game game = new Game();
            game.Run();
            Console.ReadLine();
        }
    }
}
