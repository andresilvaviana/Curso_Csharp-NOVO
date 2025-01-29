namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54781.65874;

            Console.WriteLine($"{num1:F3}");
            Console.WriteLine($"{num2:n2}");
            Console.WriteLine($"{num1:c2}");
            Console.WriteLine($"{num2:e2}");
            Console.WriteLine($"{num1:p2}");
        }
    }
}
