using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Menu
    {
        
        public static void MenuPrincipal()
        {
            Console.WriteLine("\t\t\tBem-Vindo ao programa de datas");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1. Criar uma data");
            Console.WriteLine("2. Verificar entre duas datas, qual é a mais futura");
            Console.WriteLine("3. Imprimir uma data no formato dd/mm/aaaa");
            Console.WriteLine("4. Acrescentar dias a uma data");
            Console.WriteLine("0. Sair");

        }
        
        public static Data MenuCriacaoData()
        {
            Data data;
            Console.WriteLine("Digite o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());
            try
            {
                data = new Data(dia, mes, ano);
                return data;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Parametro com erro: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            throw new Exception("Erro ao Criar data no método MenuCriacaoData de Menu");
        }

        public static Data ComparacaoEntreDatas(Data data1, Data data2)
        {
            return Data.VerificarMaiorData(data1, data2);
        }

    }
}
