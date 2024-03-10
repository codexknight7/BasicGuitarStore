using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGuitarStore
{
    internal class GuitarSpec
    {
        public string Builder { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string BackWood { get; set; }
        public string TopWood { get; set; }

        public GuitarSpec(string builder, string model, string type, string backWood, string topWood)
        {
            Builder = builder.ToLower();
            Model = model.ToLower();
            Type = type.ToLower();
            BackWood = backWood.ToLower();
            TopWood = topWood.ToLower();
        }

        public override bool Equals(Object? obj)
        {
            if (obj == null || !(obj is GuitarSpec))
                return false;
            else
                return
                    this.Builder == ((GuitarSpec)obj).Builder &&
                    this.Model == ((GuitarSpec)obj).Model &&
                    this.Type == ((GuitarSpec)obj).Type &&
                    this.BackWood == ((GuitarSpec)obj).BackWood &&
                    this.TopWood == ((GuitarSpec)obj).TopWood;
        }
    }
}
