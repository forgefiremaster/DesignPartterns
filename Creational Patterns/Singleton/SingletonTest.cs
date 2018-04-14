using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Singleton
{
    class SingletonTest
    {
        public static void Main()
        {
            var bd = BD.Instance;
        }
    }
}
