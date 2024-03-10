using BasicGuitarStore;
using System.Runtime.CompilerServices;
using System;
namespace BasicGuitarStore
{
    public class Program
    {
        private static Inventory inventory = initializeInventory();

        private static GuitarSpec whatErinLikes = new GuitarSpec("fender", "Stratocastor", "electric", "Alder", "Alder");

        public static void Main()
        {
            Console.WriteLine(whatErinLikes);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars != null && matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like this: \n");
                foreach (var guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.GuitarSpec;
                    Console.WriteLine(spec.Builder + " " + spec.Model + "\n" +
                        spec.Type + " guitar:\n " +
                        spec.BackWood + " back and sides,\n " +
                        spec.TopWood + " top.\nYou can have it for only $" +
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
            GuitarSpec spec1 = new GuitarSpec("Fender", "Stratocastor", "electric", "Alder", "Alder");
            GuitarSpec spec2 = new GuitarSpec("FENDER", "Stratocastor", "ELECTRIC", "Alder", "Alder");

            inventory.addGuitar("V95693", 1499.95, spec1);
            inventory.addGuitar("V9512", 1549.95, spec2);
            return inventory;
        }


    }
}