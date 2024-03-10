using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BasicGuitarStore
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public GuitarSpec GuitarSpec { get; set; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            GuitarSpec = spec;
        }
    }
}
