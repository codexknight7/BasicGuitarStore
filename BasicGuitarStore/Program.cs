using BasicGuitarStore;
using System.Runtime.CompilerServices;
using System;
namespace BasicGuitarStore
{
    public class Program
    {
        public static void Main()
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Dictionary<string,string> properties = new Dictionary<string,string>();
            properties.Add("InstrumentType", InstrumentType.Guitar.ToString());
            properties.Add("Builder", Builder.Stratocastor.ToString());
            properties.Add("TopWood", Wood.Maple.ToString());
            properties.Add("BackWood", Wood.Rosewood.ToString());
            InstrumentSpec clientSpec = new InstrumentSpec(properties);

            Console.WriteLine("What Erin likes: \n" + clientSpec.ToString());

            List<Instrument> matchingInstruments = inventory.search(clientSpec);
            if(matchingInstruments.Count > 0)
            {
                Console.WriteLine("You might like these instruments:");
                foreach (Instrument instrument in matchingInstruments)
                {
                    InstrumentSpec spec = instrument.Spec;
                    foreach(string key in  spec.Properties.Keys)
                    {
                        if (key == "InstrumentType")
                            continue;
                        Console.WriteLine(" " + key + ": " + spec.Properties[key]);
                    }
                    Console.WriteLine(" You can have this " + spec.Properties["InstrumentType"] + " for $" + instrument.Price + "\n---");
                }
            }
            else
            {
                Console.WriteLine("Sorry. Erin, we have nothing for you.");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("InstrumentType", InstrumentType.Guitar.ToString());
            properties.Add("Builder", Builder.Stratocastor.ToString());
            properties.Add("Model", "CJ");
            properties.Add("Type", Type.Acoustic.ToString());
            properties.Add("NumString", "6");
            properties.Add("TopWood", Wood.Maple.ToString());
            properties.Add("BackWood", Wood.Rosewood.ToString());

            inventory.addInstrument("V95693", (float)1499.95, new InstrumentSpec(properties));
        }
    }
}