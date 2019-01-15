using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes.Vertebrates.Water.Mammals;

namespace Zoo.Classes.Vertebrates.Water
{
    public class Penguin : WaterMammals
    {
        public override bool CanLayEggs { get; set; } = true;

        public override string SkinType { get; set; } = "smooth fur";
        public override string Name { get; set; } = "Mumble";

        public override string Reproduction()
        {
            return $"Can I Lay Eggs {CanLayEggs}";
        }

       
    }
}
