using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGuitarStore
{
    public class Instrument
    {
        public string SerialNumber { get; set; }
        public float Price { get; set; }
        public InstrumentSpec Spec { get; set; }    

        public Instrument(string SerialNumber, float Price, InstrumentSpec spec)
        {
            this.SerialNumber = SerialNumber;
            this.Price = Price;
            this.Spec = spec;
        }
    }
}
