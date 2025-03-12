using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    { 
        public string name;
        public int health;
        public List<string> inventory;


        // Constructor to initialize player attributes (name, health, inventory)
        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;
            this.inventory = new List<string>(); // Initializes an empty inventory
        }

            // Get method for player name
        public string GetName()
        {
            return name;
        }

        // Get method for player health
        public int GetHealth()
        {
            return health;
        }

        // Set method for player health
        public void SetHealth(int newHealth)
        {
            health = newHealth;
        }

        // Method to add an item to the player's inventory
        public void AddToInventory(string item)
        {
            inventory.Add(item);
        }

        // Method to display the player's inventory
        public void DisplayInventory()
        {
            Console.WriteLine("Inventory:");
            if (inventory.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
            }
            else
            {
                foreach (var item in inventory)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

        // Method to display player status
        public void DisplayPlayerStatus()
        {
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Health: " + health);
            DisplayInventory();
        }
    }
}
