using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes.Vertebrates.Land.Mammals;

namespace Zoo.Classes.Vertebrates
{
    public class Lion : LandMammals
    {
        public override string SkinType { get; set; } = "hairy";
        public override string Name { get; set; } = "Leo";
    }
}
