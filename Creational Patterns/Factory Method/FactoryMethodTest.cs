using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Factory_Method
{
    class FactoryMethodTest
    {
        public static void Main()
        {
            var moeda1 = MoedaFactory.criarMoeda(EnumPais.BRASIL);
            Console.WriteLine(moeda1.getSimbolo());

            var moeda2 = MoedaFactory.criarMoeda(EnumPais.USA);
            Console.WriteLine(moeda2.getSimbolo());
        }
    }
}
