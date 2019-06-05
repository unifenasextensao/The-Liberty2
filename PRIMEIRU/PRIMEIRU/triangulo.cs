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
        public override double area()
        {
            return altura*baset/2.0;
        }



    }
}
