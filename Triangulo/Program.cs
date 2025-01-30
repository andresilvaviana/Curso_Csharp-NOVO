namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Calculando A Area Total de um Triangulo");
            Console.WriteLine();
            
            Console.WriteLine("Digite a comprimeto do triagulo:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a base do triangulo:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            are(l, b);
        }

        static void are(double ba, double comprimento)
        {
            double a = ba * comprimento / 2;
            Console.WriteLine($" A area do triangulo com a base {ba} e comprimento {comprimento} é de {a:F2}² total");

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
