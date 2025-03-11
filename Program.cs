using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Dungeon");
            Console.WriteLine("Name: ");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("You awake in a cold, stone, dark room. You seem to be having trouble remembering");
            Console.WriteLine("You know your name is " + currentPlayer.name);
            Console.ReadKey();
        }
    }
}
