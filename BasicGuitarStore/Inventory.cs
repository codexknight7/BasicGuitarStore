using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicGuitarStore
{
    internal class Inventory
    {
        private List<Guitar> guitars;

        public Inventory() 
        {
            guitars = new List<Guitar>();
        }
        public void addGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber,price, builder,model,type,backWood,topWood);
            guitars.Add(guitar);
        }
        public Guitar getGuitar(string serialNumber) 
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar>matchingGuitars = new List<Guitar>();

            foreach (var guitar in guitars)
            {
                string builder = searchGuitar.Builder.ToLower();
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.Builder.ToLower())))
                {
                    continue;
                }
                string model = searchGuitar.Model.ToLower();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.Model.ToLower())))
                {
                    continue;
                }
                string type = searchGuitar.Type.ToLower();
                if ((type != null) && (!type.Equals("")) && (!type.Equals(guitar.Type.ToLower())))
                {
                    continue;
                }
                string backWood = searchGuitar.BackWood.ToLower();
                if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.BackWood.ToLower())))
                {
                    continue;
                }
                string topWood = searchGuitar.TopWood.ToLower()    ;
                if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.TopWood.ToLower())))
                {
                    continue;
                }
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }    
    }
}
