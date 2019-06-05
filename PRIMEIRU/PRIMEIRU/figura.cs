using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRU
{
	abstract class figura
	{
		private string cor;
		private string nome;

		public string Cor { get => cor; set => cor = value; }
		public string Nome { get => nome; set => nome = value; }

		public figura()
		{ }

		abstract public double area();
	}
}
