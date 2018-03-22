using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Prototype
{
    public abstract class Carro : ICloneable
    {
        public int Id { get; set; }
        public String modelo { get; set; }

        public abstract object Clone();
    }
}
