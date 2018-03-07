using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Factory_Method
{
    public class Dolar : IMoeda
    {
        public string getSimbolo()
        {
            return "USD";
        }
    }
}
