using BasicGuitarStore;
using System.Runtime.CompilerServices;
using System;
namespace BasicGuitarStore
{
    public class Program
    {
        private static Inventory inventory = initializeInventory();

        private static Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocastor", "electric", "Alder", "Alder");

        public static void Main()
        {
            Console.WriteLine(whatErinLikes);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars != null && matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like this: \n");
                foreach (var guitar in matchingGuitars)
                {
                    Console.WriteLine(guitar.Builder + " " + guitar.Model + "\n" +
                        guitar.Type + " guitar:\n " +
                        guitar.BackWood + " back and sides,\n " +
                        guitar.TopWood + " top.\nYou can have it for only $" +
                        guitar.Price + "! \n ----"
                    );
                }
            }
            else
            {
                Console.WriteLine("Sorry. Erin, we have nothing for you.");
            }
        }

        private static Inventory initializeInventory()
        {
            Inventory inventory = new Inventory();
            inventory.addGuitar("V95693", 1499.95, "Fender", "Stratocastor", "electric", "Alder", "Alder");
            inventory.addGuitar("V9512", 1549.95, "FENDER", "Stratocastor", "ELECTRIC", "Alder", "Alder");
            return inventory;
        }


    }
}