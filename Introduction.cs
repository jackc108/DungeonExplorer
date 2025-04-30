using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Introduction
    {
        public static void IntroToTheGame()
        {
            Console.WriteLine("Welcome to my unique Dungeon Crawler game");
            Console.WriteLine("Your aim is to wander around the dungeon, collect items, lvl up, get stronger until you can defeat the Boss");
            Console.WriteLine("Instructions: ");
            Console.WriteLine("Movement: W - go up / A - go left / S - go down / D - go right");
            Console.WriteLine("+ -This is you, the player");
            Console.WriteLine("W - Wall of Questions / o - plain terrain/ T - Teleporting door to a lower level of the dungeon  / E - Enemies / B - The Boss");
            Console.WriteLine("A - Armour item / S - Sword item / H - health item");
            Console.WriteLine("When in combat use A to attack, D to defend and H to heal if you poses any health potions");
            Console.WriteLine("If you ever want to remember some of the controls, enter intro");
            Console.WriteLine("That was pretty much it. Good luck and have fun!");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
