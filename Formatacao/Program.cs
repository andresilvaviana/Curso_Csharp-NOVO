namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54781.65874;

            Console.WriteLine($"{num1:F3}"); // 4 casa decimais
            Console.WriteLine($"{num2:n2}"); // separador de milhar
            Console.WriteLine($"{num1:c2}"); // moeda
            Console.WriteLine($"{num2:e2}"); // notação científica
            Console.WriteLine($"{num1:p2}"); // porcentagem
        }
    }
}
