using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Bridge.model
{
    public abstract class Forma
    {
        public Desenho desenho;

        public Forma(Desenho desenho)
        {
            this.desenho = desenho;
        }

        public abstract void desenhar();
    }
}
