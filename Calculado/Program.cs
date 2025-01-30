using System.Security.Principal;

namespace Calculado
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            string resposta = "s";

            while (resposta == "s")
            {
                escreva("Calculadora");

                Console.WriteLine("Escolha a formula desejada:");
                Console.WriteLine("1 - soma");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - multiplicação");
                Console.WriteLine("4 - divisão");
                int res = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine();
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());
                
                Console.WriteLine();
                Console.WriteLine("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                if (res == 1)
                {
                    soma(num1, num2);
                }
                if (res == 2)
                {
                    subtracao(num1, num2);
                }
                if (res == 3)
                {
                    multiplicacao(num1, num2);
                }
                if (res == 4)
                {
                    divisao(num1, num2);
                }

                Console.WriteLine("Deseja fazer outra operação? (s/n)");
                resposta = Console.ReadLine();

                Console.Clear();
            }
        }

        static void soma(double num1, double num2)
        {
            double s = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {s}");

        }
        static void subtracao(double num1, double num2)
        {
            double s = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {s}");
        }
        static void multiplicacao(double num1, double num2)
        {
            double s = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {s} ");
        }
        static void divisao(double num1, double num2)
        {
            double s = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {s} ");
        }

        static void escreva(string texto)
        {
            char caracter = '*'; // caracter que será impresso
            int tamanho = texto.Length + 4; // tamanho da linha
            string linha = new string(caracter, tamanho); // linha com o caracter
            string textocentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // texto centralizado
            Console.WriteLine(linha); // imprime a linha 
            Console.WriteLine(textocentralizado); // imprime o texto centralizado 
            Console.WriteLine(linha); // imprime a linha 



        }
    }   
}

