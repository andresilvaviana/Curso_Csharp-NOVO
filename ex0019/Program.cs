using System.Data;

namespace ex0019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruta = { "Mamão", "Laranja", "Abacaxi", "Banana Nanica", "Pera Portuguesa", "Maça Gala", "Limão", "Tomate", "Coco", "Goiaba" };
            Double[] preco = { 12.90, 8.65, 11.84, 10.99, 15.99, 7.12, 5.48, 11.99, 5.42, 9.99 };

            for (int i = 0; i < fruta.Length; i++)
            {
                Console.WriteLine(" A fruta " + fruta[i] + " tem o valor de " + preco[i]);

            }
            
            Console.WriteLine();

            string fruta_primeiro = fruta.Min();
            string fruta_ultima = fruta.Max();
            Console.WriteLine("A fruta " + fruta_primeiro + " é a primeira em ordem alfabetica.");
            Console.WriteLine("A fruta " + fruta_ultima + " é a ultima em ordem alfabetica.");

            Console.WriteLine();

            double preco_maior = preco.Max();
            double preco_menor = preco.Min();
            Console.WriteLine("A fruta mais cara custa o valor de " + preco_maior);
            Console.WriteLine("A fruta mais barata custa o valor de " + preco_menor);
            

        }

    }
}
