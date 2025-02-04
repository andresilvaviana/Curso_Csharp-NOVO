namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool mostra = false;
            char resposta;
            Console.WriteLine("Digite um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Deseja mostra os cauculos? (s/n): ");
            resposta = Convert.ToChar(Console.ReadLine().ToLower()); //ToLower() converte para minusculo e ToUpper() para maiusculo.
            Console.WriteLine();

            if (resposta == 's') { mostra = true; };

            Console.WriteLine(fatorial(num, mostra));
        }
        static int fatorial(int n, bool show=false)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.Write(i);
                    if (i < n)
                    {
                        Console.Write(" x ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }
                f *= i; // "F" é o fatorial
            }
           
            return f; // sempre que usar INT no static deve colocar RETURN no final!
        }
    }
}
