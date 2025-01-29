using System.Formats.Asn1;

namespace AreTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("CALCULAR A AREA DO TERRENO");
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine("Digite a largura do terreno:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a comprimento do terreno:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            are(l, c);
        }

        static void are(double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($" A area do terreno de {largura} por {comprimento} é de {a:F2}m²");
        }

    }
}
