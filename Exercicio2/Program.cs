using Exercicio2;
namespace ModificadoresDeAcesso
{
    public class Program
    {
        static void Main(string[] args)
        {
            Relogio relogio = new Relogio();
            relogio.Horas = 2;
            relogio.Minutos = 58;
            relogio.Segundos = 59;
            int continuar = 1;

            while(continuar != 0)
            {
                relogio.ImprimirHoras();
                Console.WriteLine("Deseja avançar as horas?");
                Console.WriteLine("Digite [1] - sim \t\t\t\t Digite [0] - não");
                continuar = int.Parse(Console.ReadLine());
                relogio.AvancarSegundos();
                Console.WriteLine("Relogio Avança 1 segundo");

            }
            
        }

    }
}
