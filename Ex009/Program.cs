namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Qual o numero? ");
            num = Convert.ToInt32(Console.ReadLine());

            if ( num % 2 == 0)
            {
                Console.WriteLine("Par {0}", num);
            }
            else
            {
                Console.WriteLine("impar {0}", num); 
            }

        }
    }
}
