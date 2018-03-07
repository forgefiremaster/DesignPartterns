﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Creational_Patterns.Abstract_Factory
{
    class Email : IMensagem
    {
        public void imprimir()
        {
            Console.WriteLine("Email");
        }
    }
}
