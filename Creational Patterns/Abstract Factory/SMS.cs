using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Abstract_Factory
{
    public class SMS : IMensagem
    {
        public void imprimir()
        {
            Console.WriteLine("SMS");
        }
    }
}
