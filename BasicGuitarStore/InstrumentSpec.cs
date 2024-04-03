using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicGuitarStore
{
    public class InstrumentSpec
    {
        public Dictionary<string, string>? Properties { get; set; }

        public InstrumentSpec(Dictionary<string,string> properties)
        {
            if(properties == null)
            {
                Properties = new Dictionary<string, string>();
            }
            Properties = properties;
        } 

        public bool Matches(InstrumentSpec spec)
        {
            if(this.Properties is null || spec.Properties is null)
            {
                return false;
            }

            var propertiesX = this.Properties;
            var propertiesY = spec.Properties;

            foreach( var property in propertiesX.Keys)
            {
                if(!propertiesY.ContainsKey(property))
                { continue; }
                if (!propertiesX[property].Equals(propertiesY[property]))
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            if(Properties is null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            foreach(string key in Properties.Keys)
            {
                sb.Append(key + ": " + Properties[key] + "\n");
            }
            return sb.ToString();
        }
    }
}
