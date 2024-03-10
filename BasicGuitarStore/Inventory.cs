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
        private List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }
        public void addGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            _guitars.Add(guitar);
        }
        public Guitar getGuitar(string serialNumber)
        {
            foreach (var guitar in _guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (var guitar in _guitars)
            {
                if (!searchGuitar.Equals(guitar.GuitarSpec))
                {
                    continue;
                }
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
