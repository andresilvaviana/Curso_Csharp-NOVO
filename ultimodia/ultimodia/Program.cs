namespace ultimodia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Voce é cliente?");
            string cliente = Convert.ToString(Console.ReadLine());
            
            Console.Clear();
            
            if (cliente == "sim")
            {
                Console.WriteLine("Informe seu cadastro");
                int cadastro1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Quer cpf na nota?");
                string cpf = Convert.ToString(Console.ReadLine());

                Console.Clear();

                if (cpf == "sim")
                {
                    Console.WriteLine("Informe seu cpf");
                    int cpf1 = Convert.ToInt32(Console.ReadLine());
                }

                Console.Clear();
            }

            if (cliente == "nao")
            {
                Console.WriteLine("Quer cpf na nota?");
                string cpf = Convert.ToString(Console.ReadLine());
                
                Console.Clear();
                
                if (cpf == "sim")
                {
                    Console.WriteLine("Informe seu cpf");
                    int cpf1 = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.Clear();

            double[] codigosdeprodutos = { 9985, 8855, 7744, 2235 };

            Console.WriteLine("Passe o codigo de barras dos produtos no leitor.");
            int codigodebarras = Convert.ToInt32(Console.ReadLine());

            if (codigodebarras == codigosdeprodutos[0])
            {
                Console.WriteLine("PaoFrances: R$ " + [0] = 5,99);
            }
            if (codigodebarras == codigosdeprodutos[1])
            {
                Console.WriteLine("PaoDoce: R$ 6,93");
            }
            if (codigodebarras == codigosdeprodutos[2])
            {
                Console.WriteLine("ArrozItegral: R$ 7,93");
            }
            if (codigodebarras == codigosdeprodutos[3])
            {
                Console.WriteLine("FeijaoPreto: R$ 8,93");
            }

            Console.WriteLine("Finalizar compras?");
            string finalizar = Convert.ToString(Console.ReadLine());

            if (finalizar == "sim")
            {
                Console.WriteLine("Valor total:  ");
                double valorpago = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
