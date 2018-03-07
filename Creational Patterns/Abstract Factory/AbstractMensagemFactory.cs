using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Abstract_Factory
{
    public abstract class AbstractMensagemFactory
    {
        public abstract IMensagem criarMensagemSms();

        public abstract IMensagem criarMensagemEmail();
    }
}
