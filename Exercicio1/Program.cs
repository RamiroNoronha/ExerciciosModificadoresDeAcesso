
using Exercicio1;

namespace ModificadoresDeAcesso
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();

            Console.Write("Digite um valor para o lado: ");
            quadrado.Lado = double.Parse(Console.ReadLine());

            Console.WriteLine("A área é: " + quadrado.CalcularArea());
            Console.WriteLine("O perimetro é: " + quadrado.CalcularPerimetro());
        }
    }
}