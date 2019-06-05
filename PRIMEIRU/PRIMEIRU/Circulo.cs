using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRU
{
    class Circulo:figura
    {
        private double raio;

        public double Raio { set => raio = value; }

        public override double area()
        {
            return (3.14*(raio * raio));
        }
    }
}
