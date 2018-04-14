using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Bridge.model
{
    public class Circlulo : Forma
    {
        public Circlulo(Desenho desenho) : base(desenho)
        {
           
        }

        public override void desenhar()
        {
            desenho.desenhar();
        }
    }
}
