using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParternExamples.Structural_Patterns.Adpter.model
{
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound(string _chemical)
        {
            this._chemical = _chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nComposto: {0} ------", _chemical);
        }
    }
}
