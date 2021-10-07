using System;

namespace SwinAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome, new player.");
            Console.WriteLine("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Tell us a bit about yourself!");
            string playerDesc = Console.ReadLine();

            Player player = new Player(playerName, playerDesc);

            Item gem = new Item(new string[] { "gem", "ruby" }, "gem", "A bright red gem");
            Item stick = new Item(new string[] { "stick" }, "stick", "A wooden stick");
            player.Inventory.Put(gem);
            player.Inventory.Put(stick);

            Bag playerBag = new Bag(new string[] { "bag", "player's bag", "knapsack" }, "your bag", "A bag");
            player.Inventory.Put(playerBag);

            Item glass = new Item(new string[] { "magnifying glass", "magnify", "glass", "zoom in" }, "magnifying glass", "A magnifying glass for adventurers");
            playerBag.Inventory.Put(glass);

            string playerCommand = Console.ReadLine();
            LookCommand look = new LookCommand(new string[] { "player" });
            look.Execute(player, playerCommand.Split());

        }
    }
}
