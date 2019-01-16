using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes.Vertebrates.Land.Mammals;

namespace Zoo.Classes.Vertebrates
{
    public class Bear : LandMammals
    {
        public override string SkinType { get; set; } = "furry";
        public override string Name { get; set; } = "Beary";
    }
}
