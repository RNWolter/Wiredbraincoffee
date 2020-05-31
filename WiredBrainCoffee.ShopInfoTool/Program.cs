using System;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee Shop Info Tool");

            Console.WriteLine("Write 'help' to list available coffee shop commands, " +
                    "write 'quit' to get out of the application");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            Console.WriteLine("So this is a holding place for something else");
            while (true)
            {
                var line = Console.ReadLine();
                Console.WriteLine("So this is a holding place");
                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
            }

        }
    }
}
