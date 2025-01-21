namespace Ex0011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            
            Console.WriteLine("informe o valor do seu salario atual: ");
            salario = Convert.ToDouble(Console.ReadLine());
            
            

            if (salario > 2500)
            {
                Console.WriteLine("Seu salario sera de {0}! Aumento de 5% sobre o valor de {1}.", ((salario * 0.05)) + salario, salario);
            }
            else if (salario > 1250)
            {
                Console.WriteLine("Seu salario sera de {0}! Aumento de 10% sobre o valor de {1}.", ((salario * 0.10)) + salario, salario);
            }
            else
            {
                Console.WriteLine("Seu salario sera de {0}! Aumento de 15% sobre o valor de {1}.", ((salario * 0.15)) + salario, salario);
            }

        }
    }
}
