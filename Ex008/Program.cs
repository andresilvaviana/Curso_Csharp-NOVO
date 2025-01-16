namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidade, valor;
            string multado;
            

            Console.WriteLine("Qual a velocidade que o seu veiculo estava? ");
            velocidade = Convert.ToInt32(Console.ReadLine());

            valor = (velocidade - 80) * 7;

            if (velocidade > 80)

            {
                Console.WriteLine("Voce foi multado! Deve ser pago o valor de {0} referente aos km excedidos", valor);
            }
            else
            {
                Console.WriteLine("Voce dirigil com prudencia!");
                
            }

           
        }
    }
}
