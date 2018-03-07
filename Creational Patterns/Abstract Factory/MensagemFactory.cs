using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Abstract_Factory
{
    public class MensagemFactory : AbstractMensagemFactory
    {
        public override IMensagem criarMensagemEmail()
        {
            return new Email();
        }

        public override IMensagem criarMensagemSms()
        {
            return new SMS();
        }
    }
}
