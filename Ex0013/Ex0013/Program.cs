namespace Ex0013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int KM;

            Console.WriteLine("Informe quantidade de KMs que sera percorida na sua viagem: ");
            KM = Convert.ToInt32(Console.ReadLine());

            if (KM < 200)
            {
                Console.WriteLine("Seu percuso custara o valor de {0}", (KM * 0.50));
            }
            else
            {
                Console.WriteLine("Seu percuso custara o valor de {0}", (KM * 0.45));
            }
        }
    }
}
