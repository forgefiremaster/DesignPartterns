using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Singleton
{
    class SingletonTest
    {
        static void Main(string[] args)
        {
            var bd = BD.Instance;
        }
    }
}
