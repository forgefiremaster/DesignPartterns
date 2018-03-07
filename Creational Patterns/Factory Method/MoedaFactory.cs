using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Factory_Method
{
    public class MoedaFactory
    {
        public static IMoeda criarMoeda(EnumPais pais)
        {
            if (pais.Equals(EnumPais.BRASIL))
                return new Real();
            else if (pais.Equals(EnumPais.BRASIL))
                return new Dolar();
            else
                return null;
        }
    }
}
