using System;

namespace Exercicio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data data = null;
            /*int dia;
            int mes;
            int ano;
            */
            int opcao;
            do
            {
                Menu.MenuPrincipal();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        data = Menu.MenuCriacaoData();
                        break;
                    /*Console.WriteLine("Digite o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o mes: ");
                    mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o ano: ");
                    ano = int.Parse(Console.ReadLine());
                    try
                    {
                        data = new Data(dia, mes, ano);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.ParamName);
                        Console.WriteLine(e.Message);
                    }
                    break;*/
                    case 2:
                        Data data1 = null;
                        Data data2 = null;
                        data1 = Menu.MenuCriacaoData();
                        data2 = Menu.MenuCriacaoData();
                        data = Menu.ComparacaoEntreDatas(data1, data2);
                        data.ImprimirData();
                        break;
                    case 3:
                        data = Menu.MenuCriacaoData();
                        data.ImprimirData();
                        break;
                    case 4:
                        data = Menu.MenuCriacaoData();
                        int op;
                        do
                        {
                            Console.WriteLine("Deseja acrescentar dias?");
                            Console.WriteLine("Digite 0 para não ou qualquer tecla para sim");
                            op = int.Parse(Console.ReadLine());
                            data.AdicionarDias();
                            data.ImprimirData();
                        } while (op != 0);
                        break;
                    default:
                        Console.WriteLine("Opcao inválida");
                        break;
                }
            } while (opcao != 0);

            
        }
    }
}
