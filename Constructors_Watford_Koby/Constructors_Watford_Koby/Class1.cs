using System;

namespace GameExample
{
    public class Game
    {
        // Public fields to store the title and genre of the game
        public string title;
        public string genre;

        // Constructor with default parameter values
        public Game(string title = "Unknown Title", string genre = "Casual")
        {
            // Set the fields to the provided parameters
            this.title = title;
            this.genre = genre;
        }
    }
}
