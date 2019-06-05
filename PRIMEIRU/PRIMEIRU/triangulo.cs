using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRU
{
	class triangulo:figura
	{
		private double altura;
		private double baset;

        public double Altura { set => altura = value; }
        public double Baset { set => baset = value; }
        

        public override double area()
        {
            return altura * baset / 2.0;
        }

    }
}
