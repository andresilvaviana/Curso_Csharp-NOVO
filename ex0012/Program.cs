namespace ex0012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;
            Console.WriteLine("   \t    ______________________,                         ");
            Console.WriteLine("   /_________I               ()                 ");
            Console.WriteLine(" \\    ___-     _____________/          ");
            Console.WriteLine("  /           /__/ ");
            Console.WriteLine(" /      /     ");
            Console.WriteLine("/______/");
            Console.WriteLine("digite o final do intervalo vacilão");
            final = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}," ,i);
                }
            }
        }
    }
}
