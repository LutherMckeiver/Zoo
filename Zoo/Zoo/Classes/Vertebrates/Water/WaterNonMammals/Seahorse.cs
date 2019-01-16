using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes.Vertebrates.Water.NonMammals;

namespace Zoo.Classes.Vertebrates.Water
{
    class Seahorse : WaterNonMammals
    {
        public override string SkinType { get; set; } = "spiky";
        public override string Name { get; set; } = "Horse Of the Sea";

        public override string WhoGetsPregnant()
        {
            return "Male";
        }

        
    }
}
