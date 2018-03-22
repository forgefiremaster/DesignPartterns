using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Prototype
{
    public class CarroCompacto : Carro
    {
        public override object Clone()
        {
            return this.MemberwiseClone() as Carro;
        }
    }
}
