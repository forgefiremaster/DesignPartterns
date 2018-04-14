using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Bridge.model
{
    public class CirculoVerde : Desenho
    {
        public void desenhar()
        {
            Console.WriteLine("Circulo verde");
        }
    }
}
