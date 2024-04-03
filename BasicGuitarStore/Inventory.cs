using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicGuitarStore
{
    public class Inventory
    {
        private List<Instrument> _instruments;

        public Inventory()
        {
            _instruments = new List<Instrument>();
        }
        public void addInstrument(string serialNumber, float price, InstrumentSpec spec)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);  
           
            _instruments.Add(instrument);
        }
        public Instrument getInstrument(string serialNumber)
        {
            Instrument instrument = null!;
            foreach (var item in _instruments)
            {
                if (item.SerialNumber.Equals(serialNumber))
                {
                    instrument = item;
                    break;
                }
            }
            return instrument;
        }
        public List<Instrument> search(InstrumentSpec searchSpec)
        {
            List<Instrument> matchingInstruments = new List<Instrument>();

            foreach (Instrument instrument in _instruments)
            {
                if (!instrument.Spec.Matches(searchSpec))
                {
                    continue;
                }
                matchingInstruments.Add(instrument);
            }
            return matchingInstruments;
        }
    }
}
