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
                try
                {
                    switch (opcao)
                    {
                        case 1:
                            data = Menu.MenuCriacaoData();
                            break;
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
                        case 0:
                            Console.WriteLine("Encerrando o programa");
                            break;
                        default:
                            Console.WriteLine("Opcao inválida");
                            break;
                    }
                }
                catch (DataException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Parametro com erro: " + e.ParamName);
                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (opcao != 0);

            
        }
    }
}
