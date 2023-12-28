using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Warzone", "FIFA 2024", "NBA 2K24", "GTA 5", "Forza" };
            var videoGameByNameLength = new List<string>(videoGames.OrderBy(x => x.Length));

            foreach(var game in videoGameByNameLength)
            {
                Console.WriteLine(game);
            }
        }


//        //Create a list of type string.
//        Populate the list with video game names.
//        Alternatively, you can choose a different category of items if you prefer.ex.list of baseball teams, list of movie titles, etc.
//        Order the list of games by the length of the game name.
//Remember to use LINQ which involves using a lambda expression.
//Use the list of common LINQ methods on the lecture page for help on deciding which method(s) to use:
//Linq Methods
//Use Method Syntax for this exercise.
//Stage, Commit, and Push your work to Github.
    }
}
