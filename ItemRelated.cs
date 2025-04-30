using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class ItemRelated
    {
        public static Sword iceSword = new Sword("Ice Sword", 15);
        public static Sword titaniumSword = new Sword("Titanium Sword", 25);
        public static Armour steelArmour = new Armour("Steel Armour", 50);
        public static Armour diamondArmour = new Armour("Diamond Armour", 150);
        public static HealthPotion healthPot = new HealthPotion("Health Potion", 30);
        public static HealthPotion healthPot2 = new HealthPotion("Health Potion", 30);
        public static HealthPotion healthPot3 = new HealthPotion("Health Potion", 30);
        public static HealthPotion healthPot4 = new HealthPotion("Health Potion", 30);
        public static HealthPotion healthPot5 = new HealthPotion("Health Potion", 30);


        public static List<string> inventory = new List<string>();
        public static List<string> equipedSword = new List<string>();
        public static List<string> equipedArmour = new List<string>();
        public static List<string> consumables = new List<string>();

        public void InventoryInteraction()
        {
            Console.WriteLine("This is your inventory.");

            Console.WriteLine("The contents are:");
            Console.WriteLine();

            foreach (string s in ItemRelated.inventory)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Equip an item.");
                Console.WriteLine("2. Unequip an item.");
                Console.WriteLine("3. Consume an item.");
                Console.WriteLine("4. Drop an item.");
                Console.WriteLine("5. See your equipped items.");
                Console.WriteLine("6. See your inventory.");
                Console.WriteLine("7. Close your inventory.");
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();

                if (input == "1")
                {
                    if (inventory.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("These are the items that you can equip.");
                        Console.WriteLine();
                        foreach (string s in ItemRelated.inventory)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine();

                        Console.WriteLine("Enter the name of the item you want to equip.");
                        string inputItem = Console.ReadLine();

                        if ((inventory.Contains(inputItem) && inputItem == "Ice Sword") && equipedSword.Count == 0)
                        {
                            iceSword.Equip();
                            inventory.Remove(inputItem);
                            equipedSword.Add(inputItem);

                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Ice Sword") && equipedSword.Count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You already have a sword equipped.");
                            Console.WriteLine("You have to unequip the one you currently have, in order to equip a new one.");
                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Steel Armour") && equipedArmour.Count == 0)
                        {
                            steelArmour.Equip();
                            inventory.Remove(inputItem);
                            equipedArmour.Add(inputItem);

                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Steel Armour") && equipedArmour.Count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You already have an armour equipped.");
                            Console.WriteLine("You have to unequip the one you currently have, in order to equip a new one.");
                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Titanium Sword") && equipedSword.Count == 0)
                        {
                            titaniumSword.Equip();
                            inventory.Remove(inputItem);
                            equipedSword.Add(inputItem);

                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Titanium Sword") && equipedSword.Count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You already have a sword equipped.");
                            Console.WriteLine("You have to unequip the one you currently have, in order to equip a new one.");
                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Diamond Armour") && equipedArmour.Count == 0)
                        {
                            diamondArmour.Equip();
                            inventory.Remove(inputItem);
                            equipedArmour.Add(inputItem);

                            Console.WriteLine();
                        }
                        else if ((inventory.Contains(inputItem) && inputItem == "Diamond Armour") && equipedArmour.Count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You already have an armour equipped.");
                            Console.WriteLine("You have to unequip the one you currently have, in order to equip a new one.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(inputItem + " cannot be equiped or it doesn't exist in your inventory");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Empty inventory. No item that can be equipped.");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine();

                    if (equipedArmour.Count > 0 || equipedSword.Count > 0)
                    {
                        Console.WriteLine("These are the items that can be unequiped");
                        if (equipedSword.Count > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("The sword you can unequip is the following: " + equipedSword.First());
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("There is no sword that can be unequipped");
                        }
                        if (equipedArmour.Count > 0)
                        {
                            Console.WriteLine("The armour you can unequip is the following: " + equipedArmour.First());
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("There is no armour that can be unequipped");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Enter the name of the item you want to unequip.");
                        string inputItem = Console.ReadLine();

                        if (equipedSword.Contains(inputItem))
                        {
                            if (inputItem == "Ice Sword")
                            {
                                iceSword.UnEquip();
                            }
                            else if (inputItem == "Titanium Sword")
                            {
                                titaniumSword.UnEquip();
                            }
                            equipedSword.Remove(inputItem);
                            inventory.Add(inputItem);
                            Console.WriteLine();
                        }
                        else if (equipedArmour.Contains(inputItem))
                        {
                            if (inputItem == "Steel Armour")
                            {
                                steelArmour.UnEquip();
                            }
                            else if (inputItem == "Diamond Armour")
                            {
                                diamondArmour.UnEquip();
                            }
                            equipedArmour.Remove(inputItem);
                            inventory.Add(inputItem);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("There is no such sword or armour to be unequipped");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no items that can be unequipped");
                        Console.WriteLine();
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("These are the items that you can consume");
                    Console.WriteLine();
                    foreach (string s in consumables)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Enter the name of the item that you want to consume");
                    string inputItem = Console.ReadLine();

                    if (consumables.Contains(inputItem))
                    {
                        Console.WriteLine();
                        healthPot.Consume();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You have no item that can be consumed or you have entered the wrong name");
                    }
                }
                else if (input == "4")
                {
                    if (inventory.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("These are the items that you can drop.");
                        Console.WriteLine();
                        foreach (string s in ItemRelated.inventory)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine();

                        Console.WriteLine("Enter the name of the item you want to drop.");
                        string inputItem = Console.ReadLine();

                        if (inventory.Contains(inputItem))
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have dropped: " + inputItem);
                            inventory.Remove(inputItem);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("There is no such item in your inventory that can be dropped");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your inventory is empty, you can't drop anything");
                        Console.WriteLine();
                    }
                }
                else if (input == "5")
                {
                    if (equipedSword.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The sword that you have equipped is the following: " + equipedSword.First());
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have no sword equipped at the moment");
                    }
                    if (equipedArmour.Count > 0)
                    {
                        Console.WriteLine("The armour that you have equipped is the following: " + equipedArmour.First());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You have no armour equipped at the moment");
                        Console.WriteLine();
                    }
                }
                else if (input == "6")
                {
                    if (inventory.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The contents of your inventory are:");
                        Console.WriteLine();

                        foreach (string s in ItemRelated.inventory)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your inventory is empty");
                        Console.WriteLine();
                    }
                }
                else if (input == "7")
                {
                    Console.WriteLine("You have closed your inventory");
                    loop = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Press 1, 2, 3 or 4");
                }
            }
        }

        public interface IItem
        {
            string Name { get; set; }
            int Value { get; set; }

            void Loot();
            void Equip();
            void Ignore();
        }

        public interface IConsumable
        {
            void Consume();
        }

        public class Sword : IItem
        {
            public string Name { get; set; }
            public int Value { get; set; }

            bool loop = true;

            public Sword(string _name, int _value)
            {
                Name = _name;
                Value = _value;
            }

            public void Loot()
            {
                Console.WriteLine("You have looted the " + Name);
                Console.WriteLine("You can find the looted item in your inventory");
                inventory.Add(Name);
                loop = false;
            }
            public void Equip()
            {
                Console.WriteLine();
                Console.WriteLine("You have equipped the " + Name);
                Program.player.dmg += Value;
                Console.WriteLine("Your damage is now " + Program.player.dmg);
            }
            public void UnEquip()
            {
                Console.WriteLine();
                Console.WriteLine("You have unequipped the " + Name);
                Program.player.dmg -= Value;
                Console.WriteLine("Your damage is now " + Program.player.dmg);
            }
            public void Ignore()
            {
                Console.WriteLine("You have ignored the item.");
                loop = false;
            }

            public void Interaction()
            {
                string input;

                Console.WriteLine("You have come across the item named " + Name);
                Console.WriteLine("It has " + Value + " damage points");
                Console.WriteLine("If you want to loot it, enter: loot, if you want to ignore it enter: ignore");


                while (loop)
                {
                    input = Console.ReadLine().ToLower();

                    if (input == "loot")
                    {
                        Loot();
                    }
                    else if (input == "ignore")
                    {
                        Ignore();
                    }
                    else
                    {
                        Console.WriteLine("That input is invalid.");
                        Console.WriteLine("If you want to loot it, enter: loot, if you want to ignore it enter: ignore");
                    }
                }
            }
        }
        public class Armour : IItem
        {
            public string Name { get; set; }
            public int Value { get; set; }

            bool loop = true;

            public Armour(string _name, int _value)
            {
                Name = _name;
                Value = _value;
            }

            public void Loot()
            {
                Console.WriteLine("You have looted the " + Name);
                Console.WriteLine("You can find the looted item in your inventory");
                inventory.Add(Name);
                loop = false;
            }
            public void Equip()
            {
                Console.WriteLine();
                Console.WriteLine("You have equipped the " + Name);
                Program.player.maxHp += Value;
                Console.WriteLine("Your maximum health is now " + Program.player.maxHp);
            }
            public void UnEquip()
            {
                Console.WriteLine();
                Console.WriteLine("You have unequipped the " + Name);
                Program.player.maxHp -= Value;
                Console.WriteLine("Your maximum health is now " + Program.player.maxHp);
            }
            public void Ignore()
            {
                Console.WriteLine("You have ignored the item.");
                loop = false;
            }

            public void Interaction()
            {
                string input;

                Console.WriteLine("You have come across the item named " + Name);
                Console.WriteLine("It has " + Value + " health points");
                Console.WriteLine("If you want to loot it, enter: loot, if you want to ignore it enter: ignore");


                while (loop)
                {
                    input = Console.ReadLine().ToLower();

                    if (input == "loot")
                    {
                        Loot();
                    }
                    else if (input == "ignore")
                    {
                        Ignore();
                    }
                    else
                    {
                        Console.WriteLine("That input is invalid.");
                        Console.WriteLine("If you want to loot it, enter: loot, if you want to ignore it enter: ignore");
                    }
                }
            }
        }
        public class HealthPotion : IItem, IConsumable
        {
            public string Name { get; set; }
            public int Value { get; set; }

            bool loop = true;

            public HealthPotion(string _name, int _value)
            {
                Name = _name;
                Value = _value;
            }
            public void Loot()
            {
                Console.WriteLine("You have looted the " + Name);
                Console.WriteLine("You can find the looted item in your inventory");
                inventory.Add(Name);
                consumables.Add(Name);
                loop = false;
            }
            public void Equip()
            {
            }
            public void Ignore()
            {
                Console.WriteLine("You have ignored the item.");
                loop = false;
            }
            public void Consume()
            {
                Art.DrawHealthPot();
                Console.WriteLine("You drank the " + Name);
                Program.player.hp += Value;
                if (Program.player.hp > Program.player.maxHp)
                {
                    Program.player.hp = Program.player.maxHp;
                }
                Console.WriteLine("Your health is now " + Program.player.hp);
                inventory.Remove(Name);
                consumables.Remove(Name);
            }

            public void Interaction()
            {
                string input;

                Console.WriteLine("You have come across the item named " + Name);
                Console.WriteLine("It can heal you for " + Value + " health points");
                Console.WriteLine("If you want to loot it, enter: loot, if you want to ignore it enter: ignore");


                while (loop)
                {
                    input = Console.ReadLine().ToLower();

                    if (input == "loot")
                    {
                        Loot();
                    }
                    else if (input == "ignore")
                    {
                        Ignore();
                    }
                    else
                    {
                        Console.WriteLine("That input is invalid.");
                        Console.WriteLine("If you want to loot it, enter: loot, if you want to ignore it enter: ignore");
                    }
                }
            }
        }
    }
}
