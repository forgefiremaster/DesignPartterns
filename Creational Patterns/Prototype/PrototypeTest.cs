using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Prototype
{
    public class PrototypeTest
    {
        static void Main(string[] args)
        {
            Carro uno = new CarroCompacto();
            uno.Id = 25;
            uno.modelo = "Compacto";

            Carro gol = uno.Clone() as CarroCompacto;
            gol.Id = 36;

            Console.WriteLine(uno.modelo + uno.Id);
            Console.WriteLine(gol.modelo + gol.Id);
        }
    }
}
