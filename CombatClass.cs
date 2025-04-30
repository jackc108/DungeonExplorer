using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class CombatClass
    {
        static string fightInput = "";
        public class Enemy
        {
            public static string name;
            public static int hp;
            public static int dmg;


            public static void Fight()
            {
                Random randy = new Random();
                int identity = randy.Next(1, 3);

                if (identity == 1)
                {
                    Enemy.name = "Underworld Minion";
                    Enemy.hp = 45;
                    Enemy.dmg = 5 + Program.currentLevel;
                }
                else if (identity == 2)
                {
                    Enemy.name = "Darkness Fighter";
                    Enemy.hp = 60;
                    Enemy.dmg = 10 + Program.currentLevel;
                }
                else if (identity == 3)
                {
                    Enemy.name = "Death Knight";
                    Enemy.hp = 80;
                    Enemy.dmg = 15 + Program.currentLevel;
                }


                Console.WriteLine("A fight begins!");
                Console.WriteLine("You are facing: " + Enemy.name);

                Console.WriteLine("      COMBAT INFO      ");
                Console.WriteLine("Your HP:" + Program.player.hp + " vs " + "Enemy's HP:" + Enemy.hp);
                Console.WriteLine("Your DMG:" + Program.player.dmg + " vs " + "Enemy's DMG:" + Enemy.dmg);
                Console.WriteLine();

                while (Enemy.hp > 0)
                {
                    Random rand = new Random();
                    int move = rand.Next(1, 100);

                    fightInput = Console.ReadLine();

                    Console.Clear();

                    if (fightInput.ToLower() == "a")
                    {
                        Enemy.hp -= Program.player.dmg;
                        Console.WriteLine();
                        Console.WriteLine("You take your sword and strike your enemy");
                        Art.DrawSword();
                    }
                    else if (fightInput.ToLower() == "d")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You take your sword and defend from your enemy");
                        Enemy.hp -= Program.player.dmg / 2;
                        Art.DrawShield();
                    }
                    else if (fightInput.ToLower() == "h" && ItemRelated.consumables.Count > 0)
                    {
                        ItemRelated.healthPot.Consume();
                        move = 101; //Setting move to 101 so that the monster won't be able to attack the player when Healing
                    }
                    else if (fightInput.ToLower() == "h" && ItemRelated.consumables.Count < 1)
                    {
                        Console.WriteLine("You have no health potion that you can consume.");
                    }
                    else
                    {
                        Console.WriteLine("You stumble and can't fight with efectivness...");
                    }

                    if (move <= 50 && Enemy.hp > 0)// the monster atacks
                    {
                        Program.player.hp -= Enemy.dmg;
                        Console.WriteLine("Your enemy adopts an offensive stance and strikes you!");
                        Console.WriteLine();
                        Art.DrawSword();
                    }
                    else if ((move > 50 && move < 101) && Enemy.hp > 0)// the monster defends
                    {
                        Program.player.hp -= Enemy.dmg / 2;
                        Console.WriteLine("Your enemy adopts a defensive stance holding his shield up!");
                        Console.WriteLine();
                        Art.DrawShield();
                    }
                    else if (move == 101)
                    {
                        //do nothing
                    }

                    Console.WriteLine("      COMBAT INFO      ");
                    Console.WriteLine("Your HP:" + Program.player.hp + " vs " + "Enemy's HP:" + Enemy.hp);
                    Console.WriteLine("Your DMG:" + Program.player.dmg + " vs " + "Enemy's DMG:" + Enemy.dmg);
                    Console.WriteLine();


                    if (Program.player.hp < 1)
                    {
                        break;
                    }
                    else if (Enemy.hp <= 0)
                    {
                        Console.WriteLine("You killed your enemy and gained 2 experience points");
                        Program.player.exp += 2;
                    }

                    if (Program.player.exp % 10 == 0 && Program.player.exp != 0)
                    {
                        Console.WriteLine("You leveled up!");
                        Program.player.hp = Program.player.maxHp;
                        Program.player.dmg += 2;
                    }
                }
            }
        }

        public class Boss
        {
            public static int hp = 200;
            public static int dmg = 50;

            public static void BossFight()
            {
                Console.WriteLine("You have finally decided to face me! I hope you are ready!");

                Console.WriteLine("      COMBAT INFO      ");
                Console.WriteLine("Your HP:" + Program.player.hp);
                Console.WriteLine("Your DMG:" + Program.player.dmg);
                Console.WriteLine();
                Console.WriteLine("Enemy's HP:" + Boss.hp);
                Console.WriteLine("Enemy's DMG:" + Boss.dmg);

                while (Boss.hp > 0)
                {
                    Random rand = new Random();
                    int move = rand.Next(1, 100);

                    fightInput = Console.ReadLine();

                    Console.Clear();

                    if (fightInput.ToLower() == "a")
                    {
                        Boss.hp -= Program.player.dmg;
                        Console.WriteLine();
                        Console.WriteLine("You take your sword and strike the Boss");
                        Art.DrawSword();
                    }
                    else if (fightInput.ToLower() == "d")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You take your sword and defend from the Boss");
                        Boss.hp -= Program.player.dmg / 2;
                        Art.DrawShield();
                    }
                    else if (fightInput.ToLower() == "h" && ItemRelated.consumables.Count > 0)
                    {
                        ItemRelated.healthPot.Consume();
                        move = 101; //Setting move to 101 so that the monster won't be able to attack the player when Healing
                    }
                    else if (fightInput.ToLower() == "h" && ItemRelated.consumables.Count < 1)
                    {
                        Console.WriteLine("You have no health potion that you can consume.");
                    }
                    else
                    {
                        Console.WriteLine("You stumble and can't fight with efectivness...");
                    }

                    if (move <= 50 && Boss.hp > 0)// the Boss atacks
                    {
                        Program.player.hp -= Boss.dmg;
                        Console.WriteLine("The Boss adopts an offensive stance and strikes you!");
                        Console.WriteLine();
                        Art.DrawSword();
                    }
                    else if ((move > 50 && move < 101) && Boss.hp > 0)// the monster defends
                    {
                        Program.player.hp -= Boss.dmg / 2;
                        Console.WriteLine("The Boss adopts a defensive stance holding his shield up!");
                        Console.WriteLine();
                        Art.DrawShield();
                    }
                    else if (move == 101)
                    {
                        //do nothing
                    }

                    Console.WriteLine("      COMBAT INFO      ");
                    Console.WriteLine("Your HP:" + Program.player.hp + " vs " + "Enemy's HP:" + Boss.hp);
                    Console.WriteLine("Your DMG:" + Program.player.dmg + " vs " + "Enemy's DMG:" + Boss.dmg);
                    Console.WriteLine();


                    if (Program.player.hp < 1)
                    {
                        break;
                    }
                    else if (Boss.hp <= 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
