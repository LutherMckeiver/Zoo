using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes.Vertebrates.Water.Mammals
{
    public abstract class WaterMammals : Water
    {
        public virtual string Sex { get; set; }

        /// <summary>
        /// Noise animals make
        /// </summary>
        /// <returns>Sound</returns>
        public string Noise()
        {
            return $"{Sound}";
        }

        /// <summary>
        /// Method going to get overriden.
        /// </summary>
        /// <returns>Which sex gets pregnant</returns>
        public virtual string WhoGetsPregnant()
        {
            return $"{Sex} gets pregnant";
        }

    }
}
