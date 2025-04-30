using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Program
    {
        public static PlayerStats player = new PlayerStats();
        public static string input = "";
        public static int currentLevel;

        public static ItemRelated myInventory = new ItemRelated();

        static void Main(string[] args)
        {
            Introduction.IntroToTheGame();//this introduces the player to the game and gives some explanations

            bool play = true;
            Random rand = new Random();

            //size of the map
            int xSize = rand.Next(10, 25);
            int ySize = rand.Next(10, 25);

            //variables that iterate trough the array of the map
            int i;
            int j;

            //used for player position and movement
            int x;
            int y;

            int wall1 = rand.Next(2, xSize - 2);
            int wall2 = rand.Next(2, ySize - 2);

            int wall1opening;
            int wall2opening;

            int xEnemy;
            int yEnemy;

            int xEnemy2;
            int yEnemy2;

            int xEnemy3;
            int yEnemy3;

            int xT;
            int yT;

            int xItem, yItem;
            int xItem2, yItem2;

            string[,] array = new string[50, 50];

            MapGeneration();

            for (i = 0; i < xSize; i++)
            {
                for (j = 0; j < ySize; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            while (play)
            {
                input = Console.ReadLine().ToLower();
                Console.Clear();

                //Movement and events depending on the destination of each step

                //Possible events that will occur if the input is the S key
                if (input.ToLower() == "s" && x < xSize - 2)
                {
                    if (array[x + 1, y] == "o")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        Console.WriteLine(array[x, y]);
                    }
                    //the wall of questions interaction
                    else if (array[x + 1, y] == "W")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        WallBreakerQuestion.Questions();
                        Console.WriteLine(array[x, y]);
                    }
                    //enemies on the map interaction
                    else if (array[x + 1, y] == "E")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        CombatClass.Enemy.Fight();
                    }
                    //boss interaction
                    else if (array[x + 1, y] == "B")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        CombatClass.Boss.BossFight();
                    }
                    //teleporting door interaction
                    else if (array[x + 1, y] == "T")
                    {
                        Console.WriteLine("You have gone deeper into the underworld");
                        MapGeneration();
                    }
                    //sword interaction
                    else if (array[x + 1, y] == "S")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.iceSword.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.titaniumSword.Interaction();
                        }
                    }
                    //armour interaction
                    else if (array[x + 1, y] == "A")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.steelArmour.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.diamondArmour.Interaction();
                        }
                    }
                    //health potion interaction
                    else if (array[x + 1, y] == "H")
                    {
                        array[x, y] = "o";
                        array[x + 1, y] = "+";
                        x++;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.healthPot.Interaction();
                        }
                        else if (currentLevel == 2)
                        {
                            ItemRelated.healthPot2.Interaction();
                        }
                        else if (currentLevel == 3)
                        {
                            ItemRelated.healthPot3.Interaction();
                        }
                        else if (currentLevel == 4)
                        {
                            ItemRelated.healthPot4.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.healthPot5.Interaction();
                        }
                    }
                }
                //Possible events that will occur if the input is the W key
                else if (input.ToLower() == "w" && x > 1)
                {
                    if (array[x - 1, y] == "o")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        Console.WriteLine(array[x, y]);
                    }
                    else if (array[x - 1, y] == "W")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        WallBreakerQuestion.Questions();
                        Console.WriteLine(array[x, y]);
                    }
                    else if (array[x - 1, y] == "E")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        CombatClass.Enemy.Fight();
                    }
                    else if (array[x - 1, y] == "T")
                    {
                        Console.WriteLine("You have gone deeper into the underworld");
                        MapGeneration();
                    }
                    else if (array[x - 1, y] == "B")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        CombatClass.Boss.BossFight();
                    }
                    else if (array[x - 1, y] == "S")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.iceSword.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.titaniumSword.Interaction();
                        }
                    }
                    else if (array[x - 1, y] == "A")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.steelArmour.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.diamondArmour.Interaction();
                        }
                    }
                    else if (array[x - 1, y] == "H")
                    {
                        array[x, y] = "o";
                        array[x - 1, y] = "+";
                        x--;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.healthPot.Interaction();
                        }
                        else if (currentLevel == 2)
                        {
                            ItemRelated.healthPot2.Interaction();
                        }
                        else if (currentLevel == 3)
                        {
                            ItemRelated.healthPot3.Interaction();
                        }
                        else if (currentLevel == 4)
                        {
                            ItemRelated.healthPot4.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.healthPot5.Interaction();
                        }
                    }
                }
                //Possible events that will occur if the input is the A key
                else if (input.ToLower() == "a" && y > 1)
                {
                    if (array[x, y - 1] == "o")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        Console.WriteLine(array[x, y]);
                    }
                    else if (array[x, y - 1] == "W")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        WallBreakerQuestion.Questions();
                        Console.WriteLine(array[x, y]);
                    }
                    else if (array[x, y - 1] == "E")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        CombatClass.Enemy.Fight();
                    }
                    else if (array[x, y - 1] == "T")
                    {
                        Console.WriteLine("You have gone deeper into the underworld");
                        MapGeneration();
                    }
                    else if (array[x, y - 1] == "B")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        CombatClass.Boss.BossFight();
                    }
                    else if (array[x, y - 1] == "S")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.iceSword.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.titaniumSword.Interaction();
                        }
                    }
                    else if (array[x, y - 1] == "A")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.steelArmour.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.diamondArmour.Interaction();
                        }
                    }
                    else if (array[x, y - 1] == "H")
                    {
                        array[x, y] = "o";
                        array[x, y - 1] = "+";
                        y--;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.healthPot.Interaction();
                        }
                        else if (currentLevel == 2)
                        {
                            ItemRelated.healthPot2.Interaction();
                        }
                        else if (currentLevel == 3)
                        {
                            ItemRelated.healthPot3.Interaction();
                        }
                        else if (currentLevel == 4)
                        {
                            ItemRelated.healthPot4.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.healthPot5.Interaction();
                        }
                    }
                }
                //Possible events that will occur if the input is the D key
                else if (input.ToLower() == "d" && y < ySize - 2)
                {
                    if (array[x, y + 1] == "o")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        Console.WriteLine(array[x, y]);
                    }
                    else if (array[x, y + 1] == "W")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        WallBreakerQuestion.Questions();
                        Console.WriteLine(array[x, y]);
                    }
                    else if (array[x, y + 1] == "E")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        CombatClass.Enemy.Fight();
                    }
                    else if (array[x, y + 1] == "T")
                    {
                        Console.WriteLine("You have gone deeper into the underworld");
                        MapGeneration();
                    }
                    else if (array[x, y + 1] == "B")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        CombatClass.Boss.BossFight();
                    }
                    else if (array[x, y + 1] == "S")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.iceSword.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.titaniumSword.Interaction();
                        }
                    }
                    else if (array[x, y + 1] == "A")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.steelArmour.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.diamondArmour.Interaction();
                        }
                    }
                    else if (array[x, y + 1] == "H")
                    {
                        array[x, y] = "o";
                        array[x, y + 1] = "+";
                        y++;
                        Console.WriteLine("You have found and item");
                        if (currentLevel == 1)
                        {
                            ItemRelated.healthPot.Interaction();
                        }
                        else if (currentLevel == 2)
                        {
                            ItemRelated.healthPot2.Interaction();
                        }
                        else if (currentLevel == 3)
                        {
                            ItemRelated.healthPot3.Interaction();
                        }
                        else if (currentLevel == 4)
                        {
                            ItemRelated.healthPot4.Interaction();
                        }
                        else if (currentLevel == 5)
                        {
                            ItemRelated.healthPot5.Interaction();
                        }
                    }
                }

                //Opening the inventory
                if (input == "i")
                {
                    myInventory.InventoryInteraction();
                }
                //Text at the begining will be shown when the player enters "intro" in case he forgot something
                else if (input.ToLower() == "intro")
                {
                    Introduction.IntroToTheGame();
                }

                //game over
                if (Program.player.hp < 1)
                {
                    Console.WriteLine();
                    Art.DrawSkull();
                    Console.WriteLine("Game Over! You died!");
                    Console.WriteLine();
                    break;
                }
                else if (CombatClass.Boss.hp < 1)
                {
                    Console.WriteLine("You defetead the Boss of the game!");
                    Console.WriteLine("Game over. You Won!");
                    break;
                }

                //First construction of the map
                for (i = 0; i < xSize; i++)
                {
                    for (j = 0; j < ySize; j++)
                    {
                        Console.Write(array[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            //method that generates the map
            void MapGeneration()
            {
                currentLevel++;

                x = 1;
                y = 1;

                //size of the map(array)
                xSize = rand.Next(10, 25);
                ySize = rand.Next(10, 25);

                wall1 = rand.Next(2, xSize - 7);
                wall2 = rand.Next(2, ySize - 7);

                wall1opening = rand.Next(2, xSize - 2);
                wall2opening = rand.Next(2, ySize - 2);

                //enemy position on the map
                xEnemy = rand.Next(2, xSize - 2);
                yEnemy = rand.Next(2, ySize - 2);

                xEnemy2 = rand.Next(2, xSize - 2);
                yEnemy2 = rand.Next(2, ySize - 2);

                xEnemy3 = rand.Next(2, xSize - 2);
                yEnemy3 = rand.Next(2, ySize - 2);

                //teleporting door position on the map
                xT = rand.Next(6, xSize - 3);
                yT = rand.Next(6, ySize - 3);

                //Sword position on the map
                xItem = rand.Next(2, 5);
                yItem = rand.Next(2, 5);

                //Armour position on the map
                xItem2 = rand.Next(2, 5);
                yItem2 = rand.Next(2, 5);

                //this if condition makes sure that the items don't overlap
                if (xItem2 == xItem)
                {
                    xItem2++;
                }

                //Health Potion location on the map
                int xHp = rand.Next(8, xSize - 2);
                int yHp = rand.Next(8, ySize - 2);

                if (xHp == xT)
                {
                    xHp++;
                }

                //the for loops that help with the visualing of the environment
                for (i = 0; i < xSize; i++)
                {
                    for (j = 0; j < ySize; j++)
                    {
                        if (i == 0 || i == xSize - 1)
                        {
                            array[i, j] = "-";
                        }
                        else if (j == 0 || j == ySize - 1)
                        {
                            array[i, j] = "|";
                        }
                        else if (i == x && j == y)
                        {
                            array[i, j] = "+";
                        }
                        else if ((i == wall1 && j != yT) && ((j != wall1opening) && (j != yEnemy)))
                        {
                            array[i, j] = "W";
                        }
                        else if ((j == wall2 && j != xT) && ((i != wall2opening) && (i != xEnemy)))
                        {
                            array[i, j] = "W";
                        }
                        else if ((i == xEnemy && j == yEnemy) || (i == xEnemy2 && j == yEnemy2) || (i == xEnemy3 && j == yEnemy3))
                        {
                            array[i, j] = "E";
                        }
                        else if (i == xSize - 2 && j == ySize - 2)
                        {
                            array[i, j] = "B";
                        }
                        else
                        {
                            array[i, j] = "o";
                        }

                        if (i == xT && j == yT)
                        {
                            array[i, j] = "T";
                        }
                        else if ((i == xHp && j == yHp) && (currentLevel == 1 || currentLevel == 2 || currentLevel == 3 || currentLevel == 4 || currentLevel == 5))
                        {
                            array[i, j] = "H";
                        }
                        else if ((i == xItem && j == yItem) && (currentLevel == 1 || currentLevel == 5))
                        {
                            array[i, j] = "S";
                        }
                        else if ((i == xItem2 && j == yItem2) && (currentLevel == 1 || currentLevel == 5))
                        {
                            array[i, j] = "A";
                        }
                    }
                }
            }
        }
    }
}
