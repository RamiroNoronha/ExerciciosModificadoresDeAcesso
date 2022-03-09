using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Quadrado
    {
        public double Lado{ get; set; }

        public double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }

        public double CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}
