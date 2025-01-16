namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("Digite a primeira nota do aluno (a): ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a primeira nota do aluno (a): ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a primeira nota do aluno (a): ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a primeira nota do aluno (a): ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final >= 70)
            {
                
                if (nota_final >= 95)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {
                    resultado = "Aprovado";
                }
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";
            }
            else 
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("A nota do aluno: {0} - Resultado: {1}", nota_final, resultado);
        }
    }
}
