namespace ex0017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5; // inicializador de variavel

            /*
            equanto a condição for verdadeira,
            o bloco de condigo seré executado.
            */

            /*
            while (num < 5)
            {
                Console.WriteLine("Curso C#");
            }
            */

            do
            {
                Console.WriteLine("Curso C#");
                num++;
            } while (num < 5);
        }
    }
}
