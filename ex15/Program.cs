namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num1;

            Console.Write("informe um numero para a multiplicação: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num1, i, num1 * i);
            }
        }       
    }
}
