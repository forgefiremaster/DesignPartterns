using DesignParternExamples.Structural_Patterns.Adpter.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Adpter
{
    class TestAdapter
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();


            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}
