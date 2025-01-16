namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.Write("Digite as nota: ");
            nota_final = Convert.ToDouble(Console.ReadLine());

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
