namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string num;

            Console.Write("informe um numero para a multiplicação: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (!int.TryParse(num, out _))
            {
                Console.Write("Digite um numero valido: ");
                num = Console.ReadLine();
            }
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num1, i, num1 * i);
            }
        }       
    }
}
