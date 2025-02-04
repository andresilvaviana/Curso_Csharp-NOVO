using System.Threading;
using System.Xml.Serialization;

namespace contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contagem(1, 5, 1);
            contagem(10, 0, 2);

            escrever("agora é sua vez de personalizar a contagem!");
            
            Console.Write("digite o inicio da contagem:");
            int ini = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("digite o final da contagem:");
            int fin = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("digite o passo da contagem:");
            int pas = Convert.ToInt32(Console.ReadLine());
            
            contagem(ini, fin, pas);

        }
        static void contagem (int i, int f, int p)
        {
            escrever($"contagem de {i} ate {f} de {p} em {p}.");
            {
                if (p < 0)
                {
                    p *= -1;
                }

                if (i < f)
                {
                    int cont = i;
                    while(cont <= f)
                    {
                        Console.Write(cont + " ");
                        Thread.Sleep(50);
                        cont += p;
                    }
                    Console.WriteLine("fim!");
                }

                else
                {
                    int cont = i;
                    while (cont >= f)
                    {
                        Console.Write(cont + " ");
                        Thread.Sleep(50);
                        cont -= p;
                    }
                    Console.WriteLine("fim!");
                }
            }
        }
        static void escrever(string texto)
        {
            int tam = texto.Length + 4;
            string Linha = new('-', tam);
            string textocentralizado = texto.PadLeft(tam - 2 ).PadRight(tam - 2 );
            Console.WriteLine(Linha);
            Console.WriteLine($"{textocentralizado}");
            Console.WriteLine(Linha);
        }
    }
}
