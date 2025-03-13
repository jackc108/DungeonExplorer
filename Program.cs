using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        //public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            // Create a new player with a name and health
            Player player1 = new Player("Hero", 100);

            // Create a new room with a description
            Room room1 = new Room("A dark and damp room with a faint smell of mildew.");

            // Display the players status
            player1.DisplayPlayerStatus();

            // Display the rooms description
            room1.DisplayDescription();

            Console.WriteLine("You find a sword and shield on the floor");

            // Add an item to the players inventory
            player1.AddToInventory("Sword");
            player1.AddToInventory("Shield");

            // Display te updated players inventory
            player1.DisplayInventory();

        }

    }
}
