using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes.Vertebrates
{
    public abstract class Vertebrates
    {
        public abstract string Name{ get; set; }
        public virtual string Sound { get; set; }
        public abstract string SkinType { get; set; }
    }
}
