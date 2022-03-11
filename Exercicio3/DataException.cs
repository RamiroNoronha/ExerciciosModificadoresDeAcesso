using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class DataException : Exception
    {
        public DataException()
        {

        }
        public DataException(string mensagem) : base(mensagem)
        {

        }
        public DataException(int dia, int mes) : 
            this("O mês " + mes +" não pode ter o dia " + dia)
        {

        }
    }
}
