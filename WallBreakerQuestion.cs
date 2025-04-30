using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class WallBreakerQuestion
    {
        public static Random rand = new Random();

        public static void Questions()
        {
            int questionNumber = rand.Next(1, 10);

            if (questionNumber < 5)
                Console.WriteLine("Welcome stranger! If you want to continue your journey unharmed, give me the right answer.");

            if (questionNumber == 1)
            {
                int a1 = rand.Next(0, 10);
                int b1 = rand.Next(0, 10);
                int a2 = rand.Next(0, 10) + 1;
                int b2 = rand.Next(0, 10);

                int a = a1 * b1;
                int b = a2 * b2;

                Console.WriteLine("Which one is greater, A or B?");
                Console.WriteLine("A. " + a1 + " x " + b1);
                Console.WriteLine("B. " + a2 + " x " + b2);

                string answer = Console.ReadLine().ToLower();
                if (answer == "a" && a > b)
                {
                    Console.WriteLine("Looks like someone is good at basic mathematics. Good for you, I guess...");
                    Console.WriteLine("You may continue your journey unharmed.");
                }
                else if (answer == "b" && b > a)
                {
                    Console.WriteLine("Looks like someone is good at basic mathematics. Good for you, I guess...");
                    Console.WriteLine("You may continue your journey unharmed.");
                }
                else
                {
                    Console.WriteLine("That was not the right answer! You lose 10 hp");
                    Program.player.hp -= 10;
                }
            }
            else if (questionNumber == 2)
            {
                Console.WriteLine("Is water wet?");

                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("You are wrong. Wet == has water on it. Water is water, it cannot have water on it");
                    Console.WriteLine("That was not the right answer! You lose 10 hp");
                    Program.player.hp -= 10;
                }
                else if (answer == "no" || answer == "n")
                {
                    Console.WriteLine("Finally a wise man... That was the right answer!");
                    Console.WriteLine("You may continue your journey unharmed.");
                }
                else
                {
                    Console.WriteLine("That was not the right answer! You lose 10 hp");
                    Program.player.hp -= 10;
                }
            }
            else if (questionNumber == 3)
            {
                Console.WriteLine("If there are 7 pigeons in a tree and you shoot one, how many pigeons are left in the tree?");
                Console.WriteLine("Please give your answers using numbers. An example would be: 10, 50, 4, 15");

                string answer = Console.ReadLine().ToLower();
                if (answer == "0")
                {
                    Console.WriteLine("I see you are a wise man. You got the right answer!");
                    Console.WriteLine("You may continue your journey unharmed.");
                }
                else
                {
                    Console.WriteLine("That answer is not right. If you shoot one of them, the rest fly away, leaving 0 in the tree.");
                    Console.WriteLine("You lose 10 hp");
                    Program.player.hp -= 10;
                }
            }
            else if (questionNumber == 4)
            {
                int a = rand.Next(1, 50);
                int b = rand.Next(1, 50);
                int sum = a + b;

                Console.WriteLine("What is the of " + a + " + " + b + " ?");
                Console.WriteLine("Please give your answers using numbers. An example would be: 10, 50, 4, 15");
                string answer = Console.ReadLine();
                if (Int32.TryParse(answer, out int answerInt) && answerInt == sum)
                {
                    Console.WriteLine("Looks like someone is good at basic mathematics. Good for you, I guess...");
                    Console.WriteLine("You may continue your journey unharmed.");
                }
                else
                {
                    Console.WriteLine("That was not the right answer! You lose 10 hp");
                    Program.player.hp -= 10;
                }
            }
            else
            {
                Console.WriteLine("It seems that this portion of the Wall isn't being guarded. You can continue your journey without being tested.");
            }
        }
    }
}
