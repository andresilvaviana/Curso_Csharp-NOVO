namespace ex0021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metodos

            //soma(10, 4);
            saudacao("André");
        }
        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("a soma de " + a + " + " + b + " = " + resultado);
        }
        static void saudacao(string nome)
        {
            Console.WriteLine(nome + ". Seja Bem Vindo!");
        }

    }
}
           