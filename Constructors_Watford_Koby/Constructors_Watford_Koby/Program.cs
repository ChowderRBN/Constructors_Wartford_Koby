using System;

namespace GameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object and initialize it with "Life is Strange 2"
            Game favoriteGame = new Game("Life is Strange 2", "Narrative Adventure");

            // Print title and genre of the favorite game
            Console.WriteLine("Favorite Game:");
            Console.WriteLine("Title: " + favoriteGame.title);
            Console.WriteLine("Genre: " + favoriteGame.genre);
            Console.WriteLine(); // For spacing

            // Create another Game object without any arguments (uses default values)
            Game defaultGame = new Game();

            // Print title and genre of the default game
            Console.WriteLine("Default Game:");
            Console.WriteLine("Title: " + defaultGame.title);
            Console.WriteLine("Genre: " + defaultGame.genre);
        }
    }
}
