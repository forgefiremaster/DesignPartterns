using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Singleton
{
    public class BD
    {
        private static BD instance;

        private BD() { }

        public static BD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BD();
                }
                return instance;
            }
        }
    }
}
