namespace impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("André Silva Viana");
            Console.WriteLine();
            escreva("COCO Bambun");
            Console.WriteLine();
            escreva("Tarzan");
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
