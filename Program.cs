using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static Game myGame = new Game();
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type your in name:");
            myGame.name = Console.ReadLine();
            Console.WriteLine("Your name is " + myGame.name);
            myGame.Start();
        }
    }
}
