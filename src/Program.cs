
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Média");
            Console.Write("Digite a quantidade de números que quer calcular a média: ");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

            List<double> numeros = new List<double>();

            for (int i = 0; i >= 0; i++) {
                Console.WriteLine($"Digite o {i+1}º número: ");
                int n1 = int.Parse(Console.ReadLine());
                vetor[i] = n1;

                System.Console.WriteLine("Quer digitar mais um número? (s/n)");
                System.Console.WriteLine($"Tamanho do vetor: {quant}");
                System.Console.WriteLine($"Números digitados: {i + 1}");

                if (Console.ReadLine().ToUpper() == "S") {
                    continue;
                }
                else if (Console.ReadLine().ToUpper() == "N") {
                    break;
                }
                else {
                    System.Console.WriteLine("Digite um valor válido");
                    continue;
                }
            }
            Console.WriteLine(calc.CalcularMedia(quant, vetor));
            
        }
    }
}

        
