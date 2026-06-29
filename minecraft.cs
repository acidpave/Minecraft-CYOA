using System;

public class Minecraft
{
    public static void Main(string[] args)
    {
        string step = "start";

        Console.WriteLine("Minecraft Java CYOA");

        while (step != "end")
        {
            if (step == "start")
            {
                Console.WriteLine("You have spawned in a square world. You can mine a tree or cobblestone. Which one will it be? (tree/cobblestone)");

                string choice = Console.ReadLine();
                if (choice == "tree")
                {
                    step = "tree";
                }
                else if (choice == "cobblestone")
                {
                    step = "cobblestone";
                }
                else
                {
                    Console.WriteLine("You really need to listen more. Get out.");
                }
            }
            else if (step == "tree")
            {
                Console.WriteLine("You have suddenly mined wood. IT'S MAGIC! You can make a crafting table or a wooden pickaxe. What will you make? (crafting table/wooden pickaxe)");
                string choice = Console.ReadLine();
                if (choice == "crafting table")
                {
                    step = "crafting table";
                }
                else if (choice == "wooden pickaxe")
                {
                    step = "wooden pickaxe";
                }
                else
                {
                    Console.WriteLine("I wish you all the best in touching grass. Please leave.");
                }
            }
            else if (step == "crafting table")
            {
                Console.WriteLine("You placethe crafting table down. It looks pretty niche, but all good things must end. Night falls and this green thing called a creeper attacks! Do you run or fight? (run/fight)");
                string choice = Console.ReadLine();
                if (choice == "run")
                {
                    Console.WriteLine("You escape into the dark.");
                    step = "start";
                }
                else
                {
                    Console.WriteLine("You try to punch the creeper with a crafting table, but it doesn't work. The creeper blows up and you die. Game over.");
                    step = "end";
                }
            }
            else if (step == "wooden pickaxe")
            {
                Console.WriteLine("You have made a wooden pickaxe. You see a block that says it's cobblestone. You go to mine it. (cobblestone)");
                string choice = Console.ReadLine();
                if (choice == "cobblestone")
                {
                    step = "cobblestone";
                }
                else
                {
                    Console.WriteLine("Please don't hit your son on the head like you mother did.");
                }
            }
            else if (step == "cobblestone")
            {
                Console.WriteLine("YA CAN'T MINE COBBLESTONE! WHAT, IS THIS CREATIVE MODE? You've lost everything to the cobblestone. You can either go back to the beach or go to a creeper to die (beach/creeper)");
                string choice = Console.ReadLine();
                if (choice == "beach")
                {
                    Console.WriteLine("You run like the wind. Back to the start menu.");
                    step = "start";
                }
                else if (choice == "creeper")
                {
                    Console.WriteLine("You walk into the darkness and find a creeper. It blows up and you die. Game over.");
                    step = "end";
                }
                else
                {
                    Console.WriteLine("You know, the world doesn't need your stupidity. Please leave.");
                }
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}
