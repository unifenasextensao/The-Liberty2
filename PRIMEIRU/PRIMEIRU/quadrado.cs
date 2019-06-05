using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRU
{
	class quadrado
	{

		private double lado;

		public double Lado { set => lado = value; }

		override public double area()
		{

			return lado * lado;
		}
	}
}
