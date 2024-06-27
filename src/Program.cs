
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Calcular media de 2 numeros");
            Console.Write("Digite o primeiro numero:");
            int primeiro = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero:");
            int segundo = int.Parse(Console.ReadLine()); 
            int resultado = primeiro + segundo / 2;
            Console.WriteLine("O resultado é: " + resultado);
            
            
        }
    }
}
