using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes.Vertebrates.Land
{
    public abstract class Land : Vertebrates
    {
        public virtual bool CanLayEggs { get; set; }

        public virtual string Reproduction()
        {
            return $"Can I lay eggs? {CanLayEggs}";
        }
        /// <summary>
        /// Abstract method that declares skintype, will be overriden.
        /// </summary>
        /// <returns> Skintype</returns>
        public string Appearance()
        {
            return $"I have {SkinType}";
        }

    }
}
