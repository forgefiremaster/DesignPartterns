using DesignParternExamples.Structural_Patterns.Bridge.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Bridge
{
    public class TesteBridge
    {
        public static void Main()
        {
            Forma f = new Circlulo(new CirculoVermelho());
            f.desenhar();
            Forma v = new Circlulo(new CirculoVerde());
            v.desenhar();
        }
    }
}
