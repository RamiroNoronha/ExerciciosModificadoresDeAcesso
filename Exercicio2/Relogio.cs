using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Relogio
    {
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public void ImprimirHoras()
        {
            Console.WriteLine("Hora: " + Horas + " |Minutos: " + Minutos + " |Segundos: " + Segundos);
        }

        public void AvancarSegundos()
        {
            Segundos++;
            if(Segundos >= 60)
            {
                Minutos++;
                Segundos -= 60;
                if(Minutos >= 60)
                {
                    Horas++;
                    Minutos -= 60;
                    if (Horas >= 24)
                    {
                        Horas -= 24;
                    }
                }
            }
        }

    }
}
