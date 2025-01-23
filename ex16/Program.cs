namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;
            
            Console.Write("Digite um genero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite um genero: ");
                genero = Console.ReadLine().ToUpper();

            }
            Console.WriteLine("Bem-Vindos e Bem-Vidas de C#!");
        }
    }
}
