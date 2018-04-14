using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Abstract_Factory
{
    class AbstractFactoryTest
    {
        public static void Main()
        {
            AbstractMensagemFactory factory = new MensagemFactory();
            var sms = factory.criarMensagemEmail(); 
            var email = factory.criarMensagemEmail();
        }
    }
}
