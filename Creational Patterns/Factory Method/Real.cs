using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Factory_Method
{
    public class Real : IMoeda
    {
        public string getSimbolo()
        {
            return "R$";
        }
    }
}
