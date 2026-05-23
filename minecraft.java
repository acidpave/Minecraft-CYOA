import java.util.Scanner;

public class minecraft {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String step = "start";
        
        System.out.println("Minecraft Java CYOA");

        while (!step.equals("end")) {
            if (step.equals("start")) {
                System.out.println("You have spawned in a square world. You can mine a tree or cobblestone. Which one will it be? (tree/cobblestone)");

                String choice = input.nextLine();
                if (choice.equals("tree")) {
                    step = "tree";
                } else if (choice.equals("cobblestone")) {
                    step = "cobblestone";
                } else {
                    System.out.println("You really need to listen more. Get out.");
                }
            }
            else if (step.equals("tree")) {
                System.out.println("You have suddenly mined wood. IT'S MAGIC! You can make a crafting table or a wooden pickaxe. What will you make? (crafting table/wooden pickaxe)");
                String choice = input.nextLine();
                if (choice.equals("crafting table")) {
                    step = "crafting table";
                } else if (choice.equals("wooden pickaxe")) {
                    step = "wooden pickaxe";
                } else {
                    System.out.println("I wish you all the best in touching grass. Please leave.");
                }
            }
            else if (step.equals("crafting table")) {
                System.out.println("You placethe crafting table down. It looks pretty niche, but all good things must end. Night falls and this green thing called a creeper attacks! Do you run or fight? (run/fight)");
                String choice = input.nextLine();
                if (choice.equals("run")) {
                    System.out.println("You escape into the dark.");
                    step = "start";
                } else {
                    System.out.println("You try to punch the creeper with a crafting table, but it doesn't work. The creeper blows up and you die. Game over.");
                    step = "end";
                }
            }
            else if (step.equals("wooden pickaxe")) {
                System.out.println("You have made a wooden pickaxe. You see a block that says it's cobblestone. You go to mine it. (cobblestone)");
                String choice = input.nextLine();
                if (choice.equals("cobblestone")) {
                    step = "cobblestone";
                } else {
                    System.out.println("Please don't hit your son on the head like you mother did.");
                }
            }
            // it gets interesting from here...
             else if (step.equals("cobblestone")) {
                System.out.println("YA CAN'T MINE COBBLESTONE! WHAT, IS THIS CREATIVE MODE? You've lost everything to the cobblestone. You can either go back to the beach or go to a creeper to die (beach/creeper)");
                String choice = input.nextLine();
                if (choice.equals("beach")) {
                    System.out.println("You run like the wind. Back to the start menu.");
                    step = "start";
                } else if (choice.equals("creeper")) {
                    System.out.println("You walk into the darkness and find a creeper. It blows up and you die. Game over.");
                    step = "end";
                } else {
                    System.out.println("You know, the world doesn't need your stupidity. Please leave.");
                }
            }
    }
    System.out.println("Thanks for playing!");
    input.close();
    }
}