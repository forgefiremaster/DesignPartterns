using DesignParternExamples.Structural_Patterns.Bridge.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Bridge
{
    public class CirculoVermelho : Desenho
    {
        public void desenhar()
        {
            Console.WriteLine("Circulo vermelho");
        }
    }
}
